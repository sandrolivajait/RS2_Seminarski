using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Models;
using Model.Requests;

namespace Windows.Administracija.Mobiteli
{
    public partial class frmMobiteli : Form
    {
        private readonly APIService mobiteli = new APIService("Mobiteli");
        private readonly APIService proizvodjaci = new APIService("Proizvodjaci");
        public frmMobiteli()
        {
            InitializeComponent();
        }

        private async void frmMobiteli_Load(object sender, EventArgs e)
        {
            dgvMobiteli.AutoGenerateColumns = false;
            var result = await mobiteli.Get<List<Model.Models.Mobiteli>>(null);



            cboxProizvodjaci.ValueMember = "Id";
            cboxProizvodjaci.DisplayMember = "Naziv";
            cboxProizvodjaci.DataSource = await proizvodjaci.Get<List<Model.Database.Proizvodjac>>(null);
            
            


            ResetCbx();

            dgvMobiteli.DataSource = result;

            
        }

        private async void btnPretraga_ClickAsync(object sender, EventArgs e)
        {
            MobiteliSearchRequest msr = new MobiteliSearchRequest
            {
                CijenaOd = (int)numFromRange.Value,
                CijenaDo = (int)numToRange.Value,
                Naziv = txtNazivMobitela.Text,
                ProizvodjacId = cboxProizvodjaci.SelectedIndex == -1 ? (int?)null : (int)cboxProizvodjaci.SelectedValue
            };


            ResetCbx();
            var result = await mobiteli.Get<List<Model.Models.Mobiteli>>(msr);
            dgvMobiteli.DataSource = result;

        }

        private void ResetCbx()
        {
            cboxProizvodjaci.SelectedItem = null;
            cboxProizvodjaci.Text = "--Izaberite--";
            cboxProizvodjaci.SelectedIndex = -1;

        }

        private void dgvMobiteli_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // implementiraj detalje mobitela.
        }

        private void dgvMobiteli_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var mobitelid = dgvMobiteli.Rows[e.RowIndex].Cells[0].Value;

            frmMobitelDetalji frm = new frmMobitelDetalji(int.Parse(mobitelid.ToString()));
            frm.Show();
        }
    }
}
