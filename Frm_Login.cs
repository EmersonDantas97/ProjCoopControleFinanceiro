namespace ProjCoopControleFinanceiro
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            Frm_Administrativo f = new Frm_Administrativo();
            f.Show();

        }
    }
}
