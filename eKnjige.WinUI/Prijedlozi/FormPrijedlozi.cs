using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI.Prijedlozi
{
    public partial class FormPrijedlozi : Form

    {
     
        
        private readonly APIService _apiservice = new APIService("prijedlogknjige");
        public FormPrijedlozi()
        {
            InitializeComponent();
            dgvPrijedlozi.AutoGenerateColumns = false;
           
        }


  

        private async void buttonTrazi_Click(object sender, EventArgs e)
        {
            string trazi = textBoxTrazi.Text;
           var result = await _apiservice.get<List<Model.PrijedlogKnjiga>>(null);
           var temp = new List<Model.PrijedlogKnjiga>();
            if (!string.IsNullOrWhiteSpace(trazi))
            {
                foreach (var item in result)
                {
                    if (item.Naziv.Contains(trazi))
                    {
                        
                        temp.Add(item);
                    }
                        

                }
                dgvPrijedlozi.DataSource = temp;
            }
            else
            {
                dgvPrijedlozi.DataSource = result;
            }

            
        }

        private async void dgvPrijedlozi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (e.ColumnIndex == 3)
            {
                id = Convert.ToInt32(dgvPrijedlozi.Rows[e.RowIndex].Cells[0].Value.ToString());
                 

                    var request = await _apiservice.getbyId<Model.PrijedlogKnjiga>(id);
                if (request.Odgovoren == false)
                {
                    request.Odgovoren = true;
                    request.Opis = "Vaša predložena knjiga je odobrena ";
                    request.PogledaoKorisnik = false;
                    await _apiservice.Update<Model.PrijedlogKnjigaRequest>(id, request);

                    MessageBox.Show("Poslana je notifikacija korisniku");
                }

            }
        }
    }
}
