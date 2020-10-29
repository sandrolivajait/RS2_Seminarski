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
    public partial class frmKvarovi : Form
    {
        private readonly APIService kvarovi = new APIService("Kvarovi");
        public frmKvarovi()
        {
            InitializeComponent();
        }

        

       

        private async void frmKvarovi_Load(object sender, EventArgs e)
        {
            dataGridViewKvarovi.AutoGenerateColumns = false;
            var result = await kvarovi.Get<List<Model.Models.Kvar>>(null);

            dataGridViewKvarovi.DataSource = result;
        }

        private void dataGridViewKvarovi_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var kvarid = dataGridViewKvarovi.Rows[e.RowIndex].Cells[0].Value;

            frmKvaroviDetalj frm = new frmKvaroviDetalj(int.Parse(kvarid.ToString()));
            frm.Show();
        }
    }
}
