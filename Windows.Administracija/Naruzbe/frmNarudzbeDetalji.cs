using Model.Database;
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

namespace Windows.Administracija.Naruzbe
{
    public partial class frmNarudzbeDetalji : Form
    {

        private NarudzbaInsertRequest insertRequest = new NarudzbaInsertRequest();
        private readonly APIService narudzbaService = new APIService("Narudzbe");
        private readonly APIService narudzbeStanjaService = new APIService("NarudzbeStanja");
        private int? _id = null;
        

        public frmNarudzbeDetalji(int ? id)
        {
            InitializeComponent();
            this._id = id;
        }

        private async void frmNarudzbeDetalji_Load(object sender, EventArgs e)
        {
            var entity = await narudzbaService.GetById<Model.Models.Narudzba>(_id);
            var stanjeNarudzbe = await narudzbeStanjaService.Get<List<StanjeKvara>>(null);

            textBoxDatum.Text = entity.Datum.ToString();
            textBoxTelefon.Text = entity.KontaktTelefon;
            textBoxImeKupca.Text = entity.ImePrezimeKupca;
            textBoxKanton.Text = entity.Kanton;
            textBoxOpcina.Text = entity.Opcina;
            textBoxUkupnaCijena.Text = entity.UkupnaCijena.ToString();
            textBoxNarucenoStavki.Text = entity.NarucenoStavki.ToString();
            textBoxUlica.Text = entity.Ulica;



            comboBoxStanjeNarudzbe.DataSource = stanjeNarudzbe;
            comboBoxStanjeNarudzbe.DisplayMember = "Opis";
            comboBoxStanjeNarudzbe.ValueMember = "Id";
            comboBoxStanjeNarudzbe.SelectedValue = entity.StanjeNarudzbeId;

            insertRequest.Datum = DateTime.Parse(entity.Datum);
            insertRequest.KontaktTelefon = entity.KontaktTelefon;
           
            insertRequest.Opcina = entity.Kanton;
            insertRequest.PostanskiBroj = entity.Opcina;
            insertRequest.UkupnaCijena = entity.UkupnaCijena;
            insertRequest.StanjeNarudzbeId = entity.StanjeNarudzbeId;
            insertRequest.Ulica = entity.Ulica;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            insertRequest.StanjeNarudzbeId = (int)comboBoxStanjeNarudzbe.SelectedValue;

            if (!_id.HasValue)
            {
                narudzbaService.Insert<Model.Models.Kvar>(insertRequest);
                MessageBox.Show("Uspješno dodan kvar");
            }
            else
            {
                narudzbaService.Update<Model.Models.Kvar>(_id.Value, insertRequest);
                MessageBox.Show("Uspješno izmjenjeni podaci o kvaru");
            }
        }
    }
}
