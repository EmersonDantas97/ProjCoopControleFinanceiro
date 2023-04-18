using ProjCoopControleFinanceiro.Model;

namespace ProjCoopControleFinanceiro
{
    public partial class Frm_Administrativo : Form
    {
        private Usuario _usuarioLogado;
        public Frm_Administrativo(Usuario usuarioLogado)
        {
            InitializeComponent();
            _usuarioLogado = usuarioLogado;
        }

        private void contraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastroConta f = new Frm_CadastroConta();
            f.MdiParent = this;
            f.Show();
        }

        private void Frm_Administrativo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
