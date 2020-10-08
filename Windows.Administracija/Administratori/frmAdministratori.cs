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
    public partial class frmAdministratori : Form
    {
        private readonly APIService administratori = new APIService("Administrator");
        public frmAdministratori()
        {
            InitializeComponent();

        }

        private async void frmAdministratori_Load(object sender, EventArgs e)
        {
            dataGridViewAdministratori.AutoGenerateColumns = false;
            var result = await administratori.Get<List<Model.Models.Administrator>>(null);

            dataGridViewAdministratori.DataSource = result;
        }

        private void dataGridViewAdministratori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var administratorid = dataGridViewAdministratori.Rows[e.RowIndex].Cells[0].Value;

            frmAdministratorDetalj frm = new frmAdministratorDetalj(int.Parse(administratorid.ToString()));
            frm.Show();
        }
    }
}
