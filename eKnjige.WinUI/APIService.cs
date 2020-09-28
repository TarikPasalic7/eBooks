using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using eKnjige.Model;
using System.Windows.Forms;

namespace eKnjige.WinUI
{
   public class APIService
    {
        public static string username { get; set; }
    public static string password { get; set; }
        public static Klijent   PrijavljeniKorisnik { get; set; }
        private string route = null;
        public APIService( string _route)
        {

            route = _route;


        }

        public async Task<T> get<T>(object search, string actionName = "")
        {
           
            
            var url =  $"{Properties.Settings.Default.APIurl}/{route}";

            if (actionName != null)
            {
                url += "/";
                url += actionName;
            }

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();

            }
             return await url.WithBasicAuth(username,password).GetJsonAsync<T>();
            
        }


        public async Task<T> getbyId<T>(object id)
        {


            var url = $"{Properties.Settings.Default.APIurl}/{route}/{id}";

           
            var result = await url.WithBasicAuth(username, password).GetJsonAsync<T>();
            return result;
        }

        public async Task<T> Insert<T>(object request)
        {


            var url = $"{Properties.Settings.Default.APIurl}/{route}";

          
            
            var result = await url.WithBasicAuth(username, password).PostJsonAsync(request).ReceiveJson<T>();
            return result;
        }

        public async Task<T> Update<T>(object id,object request)
        {


            var url = $"{Properties.Settings.Default.APIurl}/{route}/{id}";



            var result = await url.WithBasicAuth(username, password).PutJsonAsync(request).ReceiveJson<T>();
            return result;
        }

        public async Task<bool> Remove(int id)
        {
            var url = $"{Properties.Settings.Default.APIurl}/{route}/{id}";

            try
            {
                return await url.WithBasicAuth(username, password).DeleteAsync().ReceiveJson<bool>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Neuspjela prijava ili nepostojeći korisnik!");

                    return false;
                }
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Niste autorizovani");
                }

                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, {string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



    }
}
