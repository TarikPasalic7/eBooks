using Acr.UserDialogs;
using eKnjige.Model;
using EKnjige.MobileApp.Models;
using EKnjige.MobileApp.Views;
using Prism.Commands;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EKnjige.MobileApp.ViewModels
{
    class PaymentViewModel:BaseViewModel
    {
        public PaymentViewModel()
        {
            SubmitCommand = new Command(async () => await KupiKnjigu());
        }
        public PaymentViewModel(INavigation nav)
        {
            SubmitCommand = new Command(async () => await KupiKnjigu());
            this.Navigation = nav;
        }
        private readonly APIService _service = new APIService("KupovinaKnjige");

        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;
        private string _number;
        private string _cvc;

        Klijent korisnik = APIService.PrijavljeniKorisnik;
        private readonly INavigation Navigation;
        public EknjigaMobile EKnjiga { get; set; }
        private string StripeTestApiKey = "pk_test_GV7CFLcgjHOmSZYvz5rmelS900NINc2cGI";

        public string Number
        {
            get { return _number; }
            set { SetProperty(ref _number, value); }
        }
        public string Cvc
        {
            get { return _cvc; }
            set { SetProperty(ref _cvc, value); }
        }
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }
        public ICommand SubmitCommand { get; set; }

        private async Task<string> CreateTokenAsync()
        {
            
            try
            {
                StripeConfiguration.ApiKey = StripeTestApiKey;
               
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new CreditCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name =korisnik.Ime + " " + korisnik.Prezime,
                        AddressLine1 = "Marka Marulića",
                        AddressLine2 = "23",
                        AddressCity = "Grad",
                        AddressZip = "88000",
                        AddressState = "Starmo",
                        AddressCountry = "Bosna i Hercegovina",
                        Currency = "bam",
                        
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> MakePaymentAsync(string token)
        {
          
            try
            {
                StripeConfiguration.ApiKey="sk_test_coMLyIb6JOSv9IlfMOx5Fj1g0023rONhFx";
            

                var options = new ChargeCreateOptions();

                options.Amount = System.Convert.ToInt64(EKnjiga.Cijena) * 100;
                options.Currency = "bam";
                options.Description = EKnjiga.Naziv;
                options.Source = stripeToken.Id;
                options.StatementDescriptor = "Custom descriptor";
                options.Capture = true;
                options.ReceiptEmail =korisnik.Email.ToString();
                var service = new ChargeService();
                Charge charge = service.Create(options);
                UserDialogs.Instance.Alert("Uspješno ste kupili knjigu.");
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Eknjige (CreateCharge)" + ex.Message);
                throw ex;
            }
        }


        public async Task KupiKnjigu()
        {

            var kupovina = await _service.get<List<KupovinaKnjige>>(null);
            bool ima = false;
            foreach(var k in kupovina)
            {
                if (k.KlijentID == korisnik.KlijentID && EKnjiga.EKnjigaID == k.EKnjigaID)
                    ima = true;



            }
            if (ima == true)
            {

                await App.Current.MainPage.DisplayAlert("Obavijest", "Knjigu ste vec kupili", "OK");
            }
            else
            {
                CreditCardModel = new CreditCardModel();
                CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
                CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
                CreditCardModel.Number = Number;
                CreditCardModel.Cvc = Cvc;
                CancellationTokenSource tokenSource = new CancellationTokenSource();
                CancellationToken token = tokenSource.Token;
                try
                {
                    UserDialogs.Instance.ShowLoading("Payment processing..");
                    await Task.Run(async () =>
                    {

                        var Token = CreateTokenAsync();
                        Console.Write("Eknjige" + "Token :" + Token);
                        if (Token.ToString() != null)
                        {
                            IsTransectionSuccess = await MakePaymentAsync(Token.Result);
                        }
                        else
                        {
                            UserDialogs.Instance.Alert("Bad card credentials", null, "OK");
                        }
                    });
                }
                catch (Exception ex)
                {
                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert(ex.Message, null, "OK");
                    Console.Write("EKnjige" + ex.Message);
                }
                finally
                {
                    if (IsTransectionSuccess)
                    {

                        var request = new KupovinaKnjigeRequest()
                        {
                            DatumKupovine = DateTime.Now,
                            EKnjigaID = EKnjiga.EKnjigaID,
                            KlijentID = korisnik.KlijentID

                        };
                        await _service.Insert<KupovinaKnjige>(request);
                        await Navigation.PushAsync(new KnjigePage());
                        Console.Write("EKnjige" + "Payment Successful ");
                        UserDialogs.Instance.HideLoading();
                    }
                    else
                    {

                        UserDialogs.Instance.HideLoading();
                        UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");
                        Console.Write("EKnjige" + "Payment Failure ");
                    }
                }


            }

         

        }


    }
}
