namespace ProjCoopControleFinanceiro
{
    partial class Frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            pnl_BackGroundParcial = new Panel();
            pictureBox1 = new PictureBox();
            btnCadastrar = new Controls.ButtonCustom();
            lbl_TextoInformativo = new Label();
            lbl_SejaBemVindo = new Label();
            lbl_CapLogin = new Label();
            txt_Login = new TextBox();
            lbl_CapVersao = new Label();
            txt_Senha = new TextBox();
            btn_Entrar = new Button();
            btn_Sair = new Button();
            lbl_Senha = new Label();
            chkSalvar = new CheckBox();
            erroCampos = new ErrorProvider(components);
            lblUsuarioInvalido = new Label();
            lblSenhaInvalida = new Label();
            pnl_BackGroundParcial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erroCampos).BeginInit();
            SuspendLayout();
            // 
            // pnl_BackGroundParcial
            // 
            pnl_BackGroundParcial.BackColor = SystemColors.Highlight;
            pnl_BackGroundParcial.Controls.Add(pictureBox1);
            pnl_BackGroundParcial.Controls.Add(btnCadastrar);
            pnl_BackGroundParcial.Controls.Add(lbl_TextoInformativo);
            pnl_BackGroundParcial.Controls.Add(lbl_SejaBemVindo);
            pnl_BackGroundParcial.Location = new Point(0, 0);
            pnl_BackGroundParcial.Name = "pnl_BackGroundParcial";
            pnl_BackGroundParcial.Size = new Size(268, 355);
            pnl_BackGroundParcial.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.Highlight;
            btnCadastrar.BackgroundColor = SystemColors.Highlight;
            btnCadastrar.BorderColor = Color.LavenderBlush;
            btnCadastrar.BorderRadius = 17;
            btnCadastrar.BorderSize = 2;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(81, 227);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(106, 35);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextColor = Color.White;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lbl_TextoInformativo
            // 
            lbl_TextoInformativo.ForeColor = SystemColors.ControlLightLight;
            lbl_TextoInformativo.Location = new Point(23, 187);
            lbl_TextoInformativo.Name = "lbl_TextoInformativo";
            lbl_TextoInformativo.Size = new Size(227, 37);
            lbl_TextoInformativo.TabIndex = 2;
            lbl_TextoInformativo.Text = "Caso seja seu primeiro acesso clique no botão abaixo";
            lbl_TextoInformativo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_SejaBemVindo
            // 
            lbl_SejaBemVindo.AutoSize = true;
            lbl_SejaBemVindo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_SejaBemVindo.ForeColor = SystemColors.ControlLightLight;
            lbl_SejaBemVindo.Location = new Point(50, 153);
            lbl_SejaBemVindo.Name = "lbl_SejaBemVindo";
            lbl_SejaBemVindo.Size = new Size(181, 30);
            lbl_SejaBemVindo.TabIndex = 1;
            lbl_SejaBemVindo.Text = "Seja Bem Vindo!";
            // 
            // lbl_CapLogin
            // 
            lbl_CapLogin.AutoSize = true;
            lbl_CapLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_CapLogin.Location = new Point(297, 94);
            lbl_CapLogin.Name = "lbl_CapLogin";
            lbl_CapLogin.Size = new Size(37, 15);
            lbl_CapLogin.TabIndex = 4;
            lbl_CapLogin.Text = "Login";
            // 
            // txt_Login
            // 
            txt_Login.Location = new Point(297, 112);
            txt_Login.Name = "txt_Login";
            txt_Login.Size = new Size(182, 23);
            txt_Login.TabIndex = 1;
            txt_Login.TextChanged += txt_Login_TextChanged;
            txt_Login.Validating += txt_Login_Validating;
            txt_Login.Validated += txt_Login_Validated;
            // 
            // lbl_CapVersao
            // 
            lbl_CapVersao.AutoSize = true;
            lbl_CapVersao.Font = new Font("Segoe UI", 6.75F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_CapVersao.Location = new Point(440, 339);
            lbl_CapVersao.Name = "lbl_CapVersao";
            lbl_CapVersao.Size = new Size(68, 12);
            lbl_CapVersao.TabIndex = 4;
            lbl_CapVersao.Text = "Versão 01.00.00";
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(297, 168);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.PasswordChar = '*';
            txt_Senha.Size = new Size(182, 23);
            txt_Senha.TabIndex = 2;
            txt_Senha.Validating += txt_Senha_Validating;
            txt_Senha.Validated += txt_Senha_Validated;
            // 
            // btn_Entrar
            // 
            btn_Entrar.Location = new Point(348, 225);
            btn_Entrar.Name = "btn_Entrar";
            btn_Entrar.Size = new Size(75, 23);
            btn_Entrar.TabIndex = 4;
            btn_Entrar.Text = "Entrar";
            btn_Entrar.UseVisualStyleBackColor = true;
            btn_Entrar.Click += btn_Entrar_Click;
            // 
            // btn_Sair
            // 
            btn_Sair.FlatAppearance.BorderSize = 0;
            btn_Sair.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            btn_Sair.FlatStyle = FlatStyle.Flat;
            btn_Sair.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Sair.Location = new Point(487, -1);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(24, 23);
            btn_Sair.TabIndex = 0;
            btn_Sair.Text = "X";
            btn_Sair.UseVisualStyleBackColor = true;
            btn_Sair.Click += btn_Sair_Click;
            // 
            // lbl_Senha
            // 
            lbl_Senha.AutoSize = true;
            lbl_Senha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Senha.Location = new Point(297, 150);
            lbl_Senha.Name = "lbl_Senha";
            lbl_Senha.Size = new Size(40, 15);
            lbl_Senha.TabIndex = 4;
            lbl_Senha.Text = "Senha";
            // 
            // chkSalvar
            // 
            chkSalvar.AutoSize = true;
            chkSalvar.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            chkSalvar.Location = new Point(332, 200);
            chkSalvar.Name = "chkSalvar";
            chkSalvar.Size = new Size(99, 16);
            chkSalvar.TabIndex = 3;
            chkSalvar.Text = "Salvar informações";
            chkSalvar.UseVisualStyleBackColor = true;
            // 
            // erroCampos
            // 
            erroCampos.ContainerControl = this;
            // 
            // lblUsuarioInvalido
            // 
            lblUsuarioInvalido.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuarioInvalido.ForeColor = Color.Red;
            lblUsuarioInvalido.Location = new Point(348, 94);
            lblUsuarioInvalido.Name = "lblUsuarioInvalido";
            lblUsuarioInvalido.Size = new Size(131, 15);
            lblUsuarioInvalido.TabIndex = 6;
            lblUsuarioInvalido.Text = "Campo vazio/inválido!";
            lblUsuarioInvalido.Visible = false;
            // 
            // lblSenhaInvalida
            // 
            lblSenhaInvalida.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenhaInvalida.ForeColor = Color.Red;
            lblSenhaInvalida.Location = new Point(348, 150);
            lblSenhaInvalida.Name = "lblSenhaInvalida";
            lblSenhaInvalida.Size = new Size(131, 15);
            lblSenhaInvalida.TabIndex = 6;
            lblSenhaInvalida.Text = "Campo vazio/inválido!";
            lblSenhaInvalida.Visible = false;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(511, 354);
            Controls.Add(lblSenhaInvalida);
            Controls.Add(lblUsuarioInvalido);
            Controls.Add(chkSalvar);
            Controls.Add(btn_Sair);
            Controls.Add(btn_Entrar);
            Controls.Add(txt_Senha);
            Controls.Add(lbl_Senha);
            Controls.Add(lbl_CapVersao);
            Controls.Add(txt_Login);
            Controls.Add(lbl_CapLogin);
            Controls.Add(pnl_BackGroundParcial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Login";
            pnl_BackGroundParcial.ResumeLayout(false);
            pnl_BackGroundParcial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)erroCampos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_BackGroundParcial;
        private Label lbl_TextoInformativo;
        private Label lbl_SejaBemVindo;
        private Label lbl_CapLogin;
        private TextBox txt_Login;
        private Label lbl_CapVersao;
        private TextBox txt_Senha;
        private Button btn_Entrar;
        private Button btn_Sair;
        private Label lbl_Senha;
        private CheckBox chkSalvar;
        private ErrorProvider erroCampos;
        private Label lblSenhaInvalida;
        private Label lblUsuarioInvalido;
        private Controls.ButtonCustom btnCadastrar;
        private PictureBox pictureBox1;
    }
}