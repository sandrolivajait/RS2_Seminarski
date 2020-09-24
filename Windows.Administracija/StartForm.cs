using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Administracija.Mobiteli;

namespace Windows.Administracija
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMobiteli frm = new frmMobiteli();
            frm.Show();
        }
    }
}
