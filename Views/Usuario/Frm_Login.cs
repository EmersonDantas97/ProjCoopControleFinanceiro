using ProjCoopControleFinanceiro.Views.Usuario;
using ProjCoopControleFinanceiro.Presenter;
using ProjCoopControleFinanceiro.Util;
using System.Drawing.Design;

namespace ProjCoopControleFinanceiro
{
    public partial class Frm_Login : Form, IUsuarioView
    {

        private UsuarioPresenter _presenter;
        public Frm_Login()
        {
            InitializeComponent();
            _presenter = new UsuarioPresenter(this);
        }

        public string usuario
        {
            get
            {
                return txt_Login.Text;
            }
            set
            {
                txt_Login.Text = value;
            }
        }
        public string senha
        {
            get
            {
                return txt_Senha.Text;
            }
            set
            {
                txt_Senha.Text = value;
            }
        }

        public bool lembrarLogin
        {
            get
            {
                return chkSalvar.Checked;
            }
            set
            {
                chkSalvar.Checked = value;
            }
        }


        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            var usuario = _presenter.Login();
            if (usuario != null)
            {
                Hide();
                new Frm_Administrativo(usuario).Show();
            }
            else
            {
                Messages.Error("Usuário ou senha inválidos!");
            }
            _presenter.LimparTela();
        }

        private void txt_Login_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Login.Text))
            {
                //e.Cancel = true;
                txt_Login.Select(0, txt_Login.Text.Length);
                lblUsuarioInvalido.Visible = true;
                erroCampos.SetError(txt_Login, "Campo vazio/inválido!");
            }
            else
            {
                e.Cancel = false;
                erroCampos.SetError(txt_Login, "");
            }
        }

        private void txt_Login_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Login.Text))
                lblUsuarioInvalido.Visible = false;
        }

        private void txt_Senha_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Senha.Text))
            {
                //e.Cancel = true;
                txt_Login.Select(0, txt_Login.Text.Length);
                lblSenhaInvalida.Visible = true;
                erroCampos.SetError(txt_Senha, "Campo vazio/inválido!");
            }
            else
            {
                e.Cancel = false;
                erroCampos.SetError(txt_Senha, "");
            }
        }

        private void txt_Senha_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Senha.Text))
                lblSenhaInvalida.Visible = false;
        }

        private void txt_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            new Frm_CadastroLogin().ShowDialog();
        }
    }
}
