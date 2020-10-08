using Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.Administracija.Administratori
{
    public partial class frmAdministratorDetalj : Form
    {

        AdministratorInsertRequest request = new AdministratorInsertRequest();
        private readonly APIService administratorService = new APIService("Administrator");

        private int? _id = null;

        public frmAdministratorDetalj(int? id)
        {
            InitializeComponent();
            this._id = id;

          
        }

        private void textBoxIme_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxIme.TextLength < 2)
            {
                errorProvider1.SetError(textBoxIme, "Obavezno polje");
            }
        }

        private void textBoxPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPrezime.TextLength < 2)
            {
                errorProvider1.SetError(textBoxPrezime, "Obavezno polje");
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmail.TextLength < 2)
            {
                errorProvider1.SetError(textBoxEmail, "Obavezno polje");
            }

            var expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!expr.IsMatch(textBoxEmail.Text))
                errorProvider1.SetError(textBoxEmail, "Unos mora biti mail");

           
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            
            var expr = new System.Text.RegularExpressions.Regex(@"^(?=.*[a - z])(?=.*[A - Z])(?=.*\d).{ 8,15}$");
            if (!expr.IsMatch(textBoxPassword.Text))
                errorProvider1.SetError(textBoxEmail, "Password mora imati jedno malo, jedno veliko slovo i bar jedan broj.");
        }

        private void textBoxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.Compare(textBoxPassword.Text, textBoxConfirmPassword.Text) == 0)
                errorProvider1.SetError(textBoxEmail, "Potvrda passworda se mora podudarati sa pw-ordom.");

            var expr = new System.Text.RegularExpressions.Regex(@"^(?=.*[a - z])(?=.*[A - Z])(?=.*\d).{ 8,15}$");
            if (!expr.IsMatch(textBoxPassword.Text))
                errorProvider1.SetError(textBoxEmail, "Password mora imati jedno malo, jedno veliko slovo i bar jedan broj.");
        }

        private void buttonSnimi_Click(object sender, EventArgs e)
        {
            request.Email = textBoxEmail.Text;
            request.Ime = textBoxIme.Text;
            request.Prezime = textBoxPrezime.Text;
            request.Password = textBoxPassword.Text;

            if (!_id.HasValue)
            {
                administratorService.Insert<Model.Models.Mobiteli>(request);
                MessageBox.Show("Uspješno dodan administrator");
            }
            else
            {
                administratorService.Update<Model.Models.Mobiteli>(_id.Value, request);
                MessageBox.Show("Uspješno izmjenjeni podaci o administratoru");
            }

            Form.ActiveForm.Close();
        }

        private async void frmAdministratorDetalj_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var entity = await administratorService.GetById<Model.Models.Administrator>(_id);

                textBoxEmail.Text = entity.Email;
                textBoxIme.Text = entity.Ime;
                textBoxPrezime.Text = entity.Prezime;
              

            }
        }
    }
}
