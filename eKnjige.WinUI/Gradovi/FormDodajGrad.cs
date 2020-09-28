using eKnjige.WinUI.Drzave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKnjige.WinUI.Gradovi
{
    public partial class FormDodajGrad : Form
    {
        private readonly APIService servicegrad = new APIService("Grad");
        private readonly APIService servicedrzava = new APIService("Drzava");
        public FormDodajGrad()
        {
            InitializeComponent();
        }

        private  void buttonDodajDrzavu_Click(object sender, EventArgs e)
        {
            FormDodajDrzavu form = new FormDodajDrzavu();

             form.Show();
        }

        private async void FormDodajGrad_Load(object sender, EventArgs e)
        {

            var result = await servicedrzava.get<List<Model.Drzava>>(null);
            result.Insert(0, new Model.Drzava());
            cmbDrzava.DisplayMember = "Naziv";
            cmbDrzava.ValueMember = "DrzavaID";
            cmbDrzava.DataSource = result;

        }

        private async void buttonSnimiGrad_Click(object sender, EventArgs e)
        {
            var idObj = cmbDrzava.SelectedValue;
            Model.Drzava request = new Model.Drzava();
            if (int.TryParse(idObj.ToString(), out int id))
            {
                request.DrzavaID = id;
            }
            request.Naziv = textNaziv.Text;


            await servicegrad.Insert<Model.Grad>(request);
             MessageBox.Show("Operacija uspjesna");
        }



       

    }
}
