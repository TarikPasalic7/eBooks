using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI.Drzave
{
    public partial class FormDodajDrzavu : Form
    {
        private readonly APIService service = new APIService("Drzava");
        public FormDodajDrzavu()
        {
            InitializeComponent();
        }

        private async void buttonDrzavaSnimi_Click(object sender, EventArgs e)
        {
            var insert = new Model.DrzavaRequest()
            {
                Naziv = textDrzavaNaziv.Text
            };

            var result=await service.Insert<Model.DrzavaRequest>(insert);
            if(result != null)
            {
                MessageBox.Show("Država uspješno dodana.");
                DialogResult = DialogResult.OK;
                Close();

            }
            else
            {
                MessageBox.Show("Greška");
            }
     

            



        }

        private void FormDodajDrzavu_Load(object sender, EventArgs e)
        {

        }
    }
}
