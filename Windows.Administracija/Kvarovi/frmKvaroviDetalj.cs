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

namespace Windows.Administracija.Kvarovi
{
    public partial class frmKvaroviDetalj : Form
    {
        KvarInsertRequest request = new KvarInsertRequest();
        private readonly APIService kvarService = new APIService("Kvarovi");
        private readonly APIService kvarStanjaService = new APIService("KvarStanja");

        private int? _id = null;

        public frmKvaroviDetalj(int ? id)
        {
            InitializeComponent();
            this._id = id;
            
        }



        private async void frmKvaroviDetalj_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var entity = await kvarService.GetById<Model.Models.Kvar>(_id);
                var stanjaKvarova = await kvarStanjaService.Get<List<StanjeKvara>>(null);

                textBoxDatum.Text = entity.DatumKvara.ToString();
                textBoxBrojMobitela.Text = entity.BrojMobitela;
                textBoxImeKupca.Text = entity.ImeKupca;
                textBoxNazivMobitela.Text = entity.NazivMobitela;
                richTextBoxOpis.Text = entity.OpisKvara;

                

                comboBoxStanjeKvara.DataSource = stanjaKvarova;
                comboBoxStanjeKvara.DisplayMember = "Opis";
                comboBoxStanjeKvara.ValueMember = "Id";
                comboBoxStanjeKvara.SelectedValue = entity.StanjeKvaraId;

                request.DatumKvara = entity.DatumKvara;
                request.BrojMobitela = entity.BrojMobitela;
                request.KupacId = entity.KupacId;
                request.NazivMobitela = entity.NazivMobitela;
                request.OpisKvara = entity.OpisKvara;
                request.StanjeKvaraId = entity.StanjeKvaraId;



                comboBoxStanjeKvara.DataSource = stanjaKvarova;



            }
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            request.StanjeKvaraId = (int)comboBoxStanjeKvara.SelectedValue;
            
            if (!_id.HasValue)
            {
                kvarService.Insert<Model.Models.Kvar>(request);
                MessageBox.Show("Uspješno dodan kvar");
            }
            else
            {
                kvarService.Update<Model.Models.Kvar>(_id.Value, request);
                MessageBox.Show("Uspješno izmjenjeni podaci o kvaru");
            }
        }
    }
}
