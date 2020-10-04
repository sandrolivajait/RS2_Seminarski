using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.Administracija.Mobiteli
{
    public partial class frmMobitelDetalji : Form
    {
        private readonly APIService _proizvodjaci = new APIService("Proizvodjaci");
        private readonly APIService _operativniSustavi = new APIService("OperativniSustavi");
        private readonly APIService _mobiteli = new APIService("Mobiteli");
        private int? _id = null;

        public frmMobitelDetalji(int? id)
        {
            InitializeComponent();
            _id = id;


        }

        private async void frmMobitelDetalji_Load(object sender, EventArgs e)
        {
            await LoadOperativniSustavi();
            await LoadProizvodjaci();



            if (_id.HasValue)
            {
                var entity = await _mobiteli.GetById<Model.Models.Mobiteli>(_id);
                txtNaziv.Text = entity.Naziv;

                comboBoxProizvodjac.SelectedValue = entity.ProizvodjacId;
                comboBoxOperativniSustav.SelectedValue = entity.OperativniSustavId;
                numericUpDownMegapikseli.Value = (decimal)entity.Megapikseli;
                numericUpDownRAM.Value = (decimal)entity.Ram_Gb;
                numericUpDownStanjeNaSkladistu.Value = (decimal)entity.StanjeNaSkladistu;
                checkBoxEksternaMemorija.Checked = entity.EksternaMemorija;
                numericUpDownCijena.Value = (decimal)entity.Cijena;
                numericUpDownKapacitetBaterije.Value = (decimal)entity.KapacitetBaterije;
                numericUpDownTezina.Value = (decimal)entity.Tezina;
                textBoxRezolucija.Text = entity.Rezolucija;
                textBoxProcesor.Text = entity.Procesor;
                textBoxGraficka.Text = entity.Graficka;
                richTextBoxOpis.Text = entity.Opis;
                richTextBoxKratkiOpis.Text = entity.KratkiOpis;
                numericUpDownDijagonalaEkrana.Value = (decimal)entity.DijagonalaEkrana;
                cboxPopust.Checked = entity.PopustId != null;
                if (cboxPopust.Checked)
                {
                    nudPopust.Show();
                    nudPopust.Value = (decimal)entity.KolicinaPopustaDecimalni;
                }
                pictureBoxSlika.Image = byteArrayToImage(entity.SlikaThumb);


            }
        }

        public Image byteArrayToImage(byte[] bytesArr)
        {
            if (bytesArr.Length > 0)
            {
                using (MemoryStream memstr = new MemoryStream(bytesArr))
                {
                    Image img = Image.FromStream(memstr);
                    return img;
                }
            }
            return null;
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider.SetError(txtNaziv, "Obavezno polje");
            }
        }

        private async Task LoadOperativniSustavi()
        {
            var result = await _operativniSustavi.Get<List<Model.Database.OperativniSustav>>(null);

            comboBoxOperativniSustav.DataSource = result;
            comboBoxOperativniSustav.DisplayMember = "Naziv";
            comboBoxOperativniSustav.ValueMember = "Id";

            comboBoxOperativniSustav.SelectedItem = null;
            comboBoxOperativniSustav.Text = "--Izaberite--";
            comboBoxOperativniSustav.SelectedIndex = -1;

        }
        private async Task LoadProizvodjaci()
        {
            var result = await _proizvodjaci.Get<List<Model.Database.Proizvodjac>>(null);

            comboBoxProizvodjac.DataSource = result;
            comboBoxProizvodjac.DisplayMember = "Naziv";
            comboBoxProizvodjac.ValueMember = "Id";

            comboBoxProizvodjac.SelectedItem = null;
            comboBoxProizvodjac.Text = "--Izaberite--";
            comboBoxProizvodjac.SelectedIndex = -1;

        }

        private void comboBoxProizvodjac_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxProizvodjac.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxProizvodjac, "Obavezno polje");
            }
        }

        private void comboBoxOperativniSustav_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxOperativniSustav.SelectedIndex == -1)
            {
                errorProvider.SetError(comboBoxOperativniSustav, "Obavezno polje");
            }
        }

        private void textBoxRezolucija_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxRezolucija.Text))
            {
                errorProvider.SetError(textBoxRezolucija, "Obavezno polje");
            }
        }



        private void textBoxProcesor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxProcesor.Text))
            {
                errorProvider.SetError(textBoxProcesor, "Obavezno polje");
            }
        }

        private void textBoxGraficka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxGraficka.Text))
            {
                errorProvider.SetError(textBoxGraficka, "Obavezno polje");
            }
        }

        private void richTextBoxOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBoxOpis.Text))
            {
                errorProvider.SetError(richTextBoxOpis, "Obavezno polje");
            }
        }

        private void richTextBoxKratkiOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBoxKratkiOpis.Text))
            {
                errorProvider.SetError(richTextBoxKratkiOpis, "Obavezno polje");
            }
        }

        private void cboxPopust_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxPopust.Checked)
                nudPopust.Show();
            else
                nudPopust.Hide();
        }


    }
}
