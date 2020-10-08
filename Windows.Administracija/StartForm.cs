using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Administracija.Administratori;
using Windows.Administracija.Mobiteli;

namespace Windows.Administracija
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMobiteli frm = new frmMobiteli();
            
            frm.Show();
        }

        private void dodavanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMobitelDetalji frm = new frmMobitelDetalji(null);
            
            frm.Show();
        }

        private void dodavanjeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAdministratorDetalj frm = new frmAdministratorDetalj(null);
           
            frm.Show();
        }

        private void pretragaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmAdministratori frm = new frmAdministratori();
           
            frm.Show();
        }

        private void pretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmKupci frm = new frmKupci();

            frm.Show();
        }

        private void dodavanjeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmKupciDetalj frm = new frmKupciDetalj(null);

            frm.Show();
        }

        private void pretragaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmNarudzbe frm = new frmNarudzbe();

            frm.Show();
        }
    }
}
