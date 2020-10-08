using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.Administracija
{
    public partial class LoginForm : Form
    {
        private readonly APIService _administrator = new APIService("Administrator");
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            Model.Models.Administrator korisnik = await _administrator.Authenticiraj<Model.Models.Administrator>(textBoxEmail.Text, textBoxPassword.Text);

            if (korisnik != null)
            {
                Global.PrijavljeniKorisnik = korisnik;

                MessageBox.Show("Dobrodosli " + korisnik.Ime + " " + korisnik.Prezime);
                DialogResult = DialogResult.OK;

                
                
                Close();


            }
            else
            {
                MessageBox.Show("Pogresan username ili password", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmail.TextLength < 2)
            {
                errorProvider1.SetError(textBoxEmail, "Obavezno polje");
            }
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPassword.TextLength < 2)
            {
                errorProvider1.SetError(textBoxPassword, "Obavezno polje");
            }
        }
    }
}
