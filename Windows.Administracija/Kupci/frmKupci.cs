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
    public partial class frmKupci : Form
    {
        private readonly APIService kupci = new APIService("Kupac");
        public frmKupci()
        {
            InitializeComponent();

        }

        private async void frmAdministratori_Load(object sender, EventArgs e)
        {
            dataGridViewKupci.AutoGenerateColumns = false;
            var result = await kupci.Get<List<Model.Models.Kupac>>(null);

            dataGridViewKupci.DataSource = result;
        }

        private void dataGridViewAdministratori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var administratorid = dataGridViewKupci.Rows[e.RowIndex].Cells[0].Value;

            frmKupciDetalj frm = new frmKupciDetalj(int.Parse(administratorid.ToString()));
            frm.Show();
        }
    }
}
