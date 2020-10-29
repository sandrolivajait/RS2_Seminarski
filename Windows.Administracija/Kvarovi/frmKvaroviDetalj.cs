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

                textBoxDatum.Text = entity.DatumKvara.ToString();
                textBoxBrojMobitela.Text = entity.BrojMobitela;
                textBoxImeKupca.Text = entity.ImeKupca;
                textBoxNazivMobitela.Text = entity.NazivMobitela;
                richTextBoxOpis.Text = entity.OpisKvara;
                comboBoxStanjeKvara.DataSource = kvarStanjaService.Get<List<Kvar>>(null);
                comboBoxStanjeKvara.SelectedValue = entity.StanjeKvaraId;



            }
        }

        
    }
}
