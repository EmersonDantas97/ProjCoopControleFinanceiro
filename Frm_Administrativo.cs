using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjCoopControleFinanceiro
{
    public partial class Frm_Administrativo : Form
    {
        public Frm_Administrativo()
        {
            InitializeComponent();
        }

        private void contraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastroConta f = new Frm_CadastroConta();
            f.MdiParent = this;
            f.Show();
        }
    }
}
