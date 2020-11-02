using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Administracija.Naruzbe;

namespace Windows.Administracija.Administratori
{
    public partial class frmNarudzbe : Form
    {
        private readonly APIService narudzbe = new APIService("Narudzba");
        public frmNarudzbe()
        {
            InitializeComponent();

        }

       

        private async void frmNarudzbe_Load(object sender, EventArgs e)
        {
            dataGridViewZavrsene.AutoGenerateColumns = false;
            dataGridViewNezavrsene.AutoGenerateColumns = false;

            var result = await narudzbe.Get<List<Model.Models.Narudzba>>(null);

            dataGridViewZavrsene.DataSource = result.Where(x => x.StanjeNarudzbeId == 4).ToList();
            dataGridViewNezavrsene.DataSource = result.Where(x => x.StanjeNarudzbeId != 4).ToList();
        }

        private void dataGridViewNezavrsene_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var nezavrseneDoubleClick = dataGridViewNezavrsene.Rows[e.RowIndex].Cells[0].Value;

            frmNarudzbeDetalji frm = new frmNarudzbeDetalji(int.Parse(nezavrseneDoubleClick.ToString()));
            frm.Show();
        }

        private void dataGridViewZavrsene_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var nezavrseneDoubleClick = dataGridViewZavrsene.Rows[e.RowIndex].Cells[0].Value;

            frmNarudzbeDetalji frm = new frmNarudzbeDetalji(int.Parse(nezavrseneDoubleClick.ToString()));
            frm.Show();
        }
    }
}
