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
    public partial class frmNarudzbe : Form
    {
        private readonly APIService narudzbe = new APIService("Narudzbe");
        public frmNarudzbe()
        {
            InitializeComponent();

        }

        private void dataGridViewAdministratori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var administratorid = dataGridViewZavrsene.Rows[e.RowIndex].Cells[0].Value;

            frmAdministratorDetalj frm = new frmAdministratorDetalj(int.Parse(administratorid.ToString()));
            frm.Show();
        }

        private async void frmNarudzbe_Load(object sender, EventArgs e)
        {
            dataGridViewZavrsene.AutoGenerateColumns = true;
            dataGridViewNezavrsene.AutoGenerateColumns = true;

            var result = await narudzbe.Get<List<Model.Models.Narudzba>>(null);

            dataGridViewZavrsene.DataSource = result.Where(x => x.Stanje == 5);
            dataGridViewNezavrsene.DataSource = result.Where(x => x.Stanje != 5);
        }
    }
}
