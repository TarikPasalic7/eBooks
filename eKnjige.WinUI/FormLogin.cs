using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI
{
    public partial class FormLogin : Form
    {
        APIService apiservice = new APIService("Klijenti");
        public FormLogin()
        {
            InitializeComponent();
        }

        private async void buttonlogin_Click(object sender, EventArgs e)
        {
            APIService.username = textKorisnickoIme.Text;
            APIService.password = textLozinka.Text;
            
            try
            {
                APIService.PrijavljeniKorisnik = await apiservice.get<Model.Klijent>(null, "Profil");
                //
                if (APIService.PrijavljeniKorisnik.Uloga.Naziv == "Administrator")
                {
                    await apiservice.get<dynamic>(null);
                    this.Hide();
                    FormIndex form = new FormIndex();

                   
                    DialogResult = DialogResult.OK;
                    form.Show();
                   
                    
                  

                }
                else
                {
                    throw new Exception("Unos nije ispravan");
                   
                }
               
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }
    }
}
