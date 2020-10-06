using Model.Requests;
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
        MobiteliInsertRequest request = new MobiteliInsertRequest();

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
                request.PopustId = entity.PopustId;

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
            if (cboxPopust.Checked) { 
                nudPopust.Show();
                labelPopustDo.Show();
                labelPopustOd.Show();
                dateTimePickerPopustDo.Show();
                dateTimePickerPopustOd.Show();
            }
            else { 
                nudPopust.Hide();
                labelPopustDo.Hide();
                labelPopustOd.Hide();
                dateTimePickerPopustDo.Hide();
                dateTimePickerPopustOd.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Slika = file;
                textBoxSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                Image thumb = image.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
                thumb.Save(Path.ChangeExtension(fileName, "thumb"));


                request.SlikaThumb = ImageToByteArray(thumb);


                pictureBoxSlika.Image = thumb;
            }
        }

        public static byte[] ImageToByteArray(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            request.Naziv = txtNaziv.Text;
            request.ProizvodjacId = (int)comboBoxProizvodjac.SelectedValue;
            request.OperativniSustavId = (int)comboBoxOperativniSustav.SelectedValue;
            request.Megapikseli = (float)numericUpDownMegapikseli.Value;
            request.Ram_Gb = (float)numericUpDownRAM.Value;
            request.StanjeNaSkladistu = (int)numericUpDownStanjeNaSkladistu.Value ;
            request.EksternaMemorija = checkBoxEksternaMemorija.Checked;
            request.Cijena = (double)numericUpDownCijena.Value;
            request.KapacitetBaterije = (int)numericUpDownKapacitetBaterije.Value;
            request.Tezina = (int)numericUpDownTezina.Value;
            request.Rezolucija = textBoxRezolucija.Text;
            request.Procesor = textBoxProcesor.Text;
            request.Graficka = textBoxGraficka.Text;
            request.Opis = richTextBoxOpis.Text;
            request.KratkiOpis = richTextBoxKratkiOpis.Text;

            request.DijagonalaEkrana = (float)numericUpDownDijagonalaEkrana.Value;
            
           

            if (cboxPopust.Checked)
            {
                request.KolicinaPopusta = nudPopust.Value;
                request.PopustOd = dateTimePickerPopustOd.Value;
                request.PopustDo = dateTimePickerPopustDo.Value;
            }

            if(pictureBoxSlika.Image != null)
            {
                Image i = pictureBoxSlika.Image;
                request.Slika = ImageToByteArray(i);
                Image thumb = i.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
                request.SlikaThumb = ImageToByteArray(thumb);
            }

            if (!_id.HasValue)
            {
                _mobiteli.Insert<Model.Models.Mobiteli>(request);
                MessageBox.Show("Uspješno dodan artikal");
            }
            else
            {
                _mobiteli.Update<Model.Models.Mobiteli>(_id.Value, request);
                MessageBox.Show("Uspješno izmjenjeni podaci o artiklu");
            }

            Form.ActiveForm.Close();

        }
    }
}
