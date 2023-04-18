using ProjCoopControleFinanceiro.Presenter;
using ProjCoopControleFinanceiro.Views.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjCoopControleFinanceiro
{
    public partial class Frm_CadastroLogin : Form, IUsuarioView
    {
        private UsuarioPresenter presenter;
        public Frm_CadastroLogin()
        {
            InitializeComponent();
            presenter = new UsuarioPresenter(this);
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

        private void Frm_CadastroLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            if (lblConfirmarInvalida.Visible || lblSenhaInvalida.Visible || lblUsuarioInvalido.Visible)
                return;


            if (presenter.Cadastro() > 0)
            {
                Util.Messages.Success("Cadastro efetuado com sucesso!");
                this.Close();
            }
        }

        private void txt_Login_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Login.Text))
            {
                lblUsuarioInvalido.Visible = true;
            }
            else
            {
                e.Cancel = false;
                lblUsuarioInvalido.Visible = false;
            }
        }

        private void txt_Senha_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Senha.Text))
            {
                lblSenhaInvalida.Visible = true;
            }
            else
            {
                e.Cancel = false;
                lblSenhaInvalida.Visible = false;
            }
        }

        private void txt_ConfirmarSenha_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ConfirmarSenha.Text))
            {
                lblConfirmarInvalida.Visible = true;
            }
            else if(txt_ConfirmarSenha.Text != txt_Senha.Text)
            {
                e.Cancel = true;
                lblConfirmarInvalida.Visible = true;
                lblConfirmarInvalida.Text = "Senhas não conferem!";
            }
            else
            {
                e.Cancel = false;
                lblConfirmarInvalida.Visible = false;
            }
        }
    }
}
