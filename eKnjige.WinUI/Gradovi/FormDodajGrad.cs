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
            this.AutoValidate = AutoValidate.Disable;
        }

        private async  void buttonDodajDrzavu_Click(object sender, EventArgs e)
        {
            FormDodajDrzavu form = new FormDodajDrzavu();

            if (form.ShowDialog() == DialogResult.OK)
            {

                var result = await servicedrzava.get<List<Model.Drzava>>(null);
                cmbDrzava.DataSource = result;

            }

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
            if (this.ValidateChildren())
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
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void textNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNaziv.Text))
            {

                errorProvider.SetError(textNaziv, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textNaziv, null);
            }
        }

        private void cmbDrzava_Validating(object sender, CancelEventArgs e)
        {
            if (cmbDrzava.SelectedValue == null)
            {

                errorProvider.SetError(cmbDrzava, "Obavezno Polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbDrzava, null);
            }
        }
    }
}
