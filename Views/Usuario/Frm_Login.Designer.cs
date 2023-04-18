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
            this.components = new System.ComponentModel.Container();
            this.pnl_BackGroundParcial = new System.Windows.Forms.Panel();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.lbl_TextoInformativo = new System.Windows.Forms.Label();
            this.lbl_SejaBemVindo = new System.Windows.Forms.Label();
            this.lbl_CapLogin = new System.Windows.Forms.Label();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.lbl_CapVersao = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.chkSalvar = new System.Windows.Forms.CheckBox();
            this.erroCampos = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUsuarioInvalido = new System.Windows.Forms.Label();
            this.lblSenhaInvalida = new System.Windows.Forms.Label();
            this.buttonCustom1 = new ProjCoopControleFinanceiro.Controls.ButtonCustom();
            this.pnl_BackGroundParcial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroCampos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_BackGroundParcial
            // 
            this.pnl_BackGroundParcial.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnl_BackGroundParcial.Controls.Add(this.buttonCustom1);
            this.pnl_BackGroundParcial.Controls.Add(this.btn_Cadastrar);
            this.pnl_BackGroundParcial.Controls.Add(this.lbl_TextoInformativo);
            this.pnl_BackGroundParcial.Controls.Add(this.lbl_SejaBemVindo);
            this.pnl_BackGroundParcial.Location = new System.Drawing.Point(0, 0);
            this.pnl_BackGroundParcial.Name = "pnl_BackGroundParcial";
            this.pnl_BackGroundParcial.Size = new System.Drawing.Size(268, 355);
            this.pnl_BackGroundParcial.TabIndex = 5;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cadastrar.Location = new System.Drawing.Point(94, 285);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 30);
            this.btn_Cadastrar.TabIndex = 7;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // lbl_TextoInformativo
            // 
            this.lbl_TextoInformativo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_TextoInformativo.Location = new System.Drawing.Point(23, 158);
            this.lbl_TextoInformativo.Name = "lbl_TextoInformativo";
            this.lbl_TextoInformativo.Size = new System.Drawing.Size(227, 37);
            this.lbl_TextoInformativo.TabIndex = 2;
            this.lbl_TextoInformativo.Text = "Caso seja seu primeiro acesso clique no botão abaixo";
            this.lbl_TextoInformativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SejaBemVindo
            // 
            this.lbl_SejaBemVindo.AutoSize = true;
            this.lbl_SejaBemVindo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SejaBemVindo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_SejaBemVindo.Location = new System.Drawing.Point(50, 124);
            this.lbl_SejaBemVindo.Name = "lbl_SejaBemVindo";
            this.lbl_SejaBemVindo.Size = new System.Drawing.Size(181, 30);
            this.lbl_SejaBemVindo.TabIndex = 1;
            this.lbl_SejaBemVindo.Text = "Seja Bem Vindo!";
            // 
            // lbl_CapLogin
            // 
            this.lbl_CapLogin.AutoSize = true;
            this.lbl_CapLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CapLogin.Location = new System.Drawing.Point(297, 94);
            this.lbl_CapLogin.Name = "lbl_CapLogin";
            this.lbl_CapLogin.Size = new System.Drawing.Size(37, 15);
            this.lbl_CapLogin.TabIndex = 4;
            this.lbl_CapLogin.Text = "Login";
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(297, 112);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(182, 23);
            this.txt_Login.TabIndex = 1;
            // 
            // lbl_CapVersao
            // 
            this.lbl_CapVersao.AutoSize = true;
            this.lbl_CapVersao.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_CapVersao.Location = new System.Drawing.Point(440, 339);
            this.lbl_CapVersao.Name = "lbl_CapVersao";
            this.lbl_CapVersao.Size = new System.Drawing.Size(68, 12);
            this.lbl_CapVersao.TabIndex = 4;
            this.lbl_CapVersao.Text = "Versão 01.00.00";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(297, 168);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(182, 23);
            this.txt_Senha.TabIndex = 2;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Location = new System.Drawing.Point(348, 225);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Entrar.TabIndex = 4;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            // 
            // btn_Sair
            // 
            this.btn_Sair.FlatAppearance.BorderSize = 0;
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Sair.Location = new System.Drawing.Point(487, -1);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(24, 23);
            this.btn_Sair.TabIndex = 0;
            this.btn_Sair.Text = "X";
            this.btn_Sair.UseVisualStyleBackColor = true;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Senha.Location = new System.Drawing.Point(297, 150);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(40, 15);
            this.lbl_Senha.TabIndex = 4;
            this.lbl_Senha.Text = "Senha";
            // 
            // chkSalvar
            // 
            this.chkSalvar.AutoSize = true;
            this.chkSalvar.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkSalvar.Location = new System.Drawing.Point(332, 200);
            this.chkSalvar.Name = "chkSalvar";
            this.chkSalvar.Size = new System.Drawing.Size(99, 16);
            this.chkSalvar.TabIndex = 3;
            this.chkSalvar.Text = "Salvar informações";
            this.chkSalvar.UseVisualStyleBackColor = true;
            // 
            // erroCampos
            // 
            this.erroCampos.ContainerControl = this;
            // 
            // lblUsuarioInvalido
            // 
            this.lblUsuarioInvalido.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuarioInvalido.ForeColor = System.Drawing.Color.Red;
            this.lblUsuarioInvalido.Location = new System.Drawing.Point(348, 94);
            this.lblUsuarioInvalido.Name = "lblUsuarioInvalido";
            this.lblUsuarioInvalido.Size = new System.Drawing.Size(131, 15);
            this.lblUsuarioInvalido.TabIndex = 6;
            this.lblUsuarioInvalido.Text = "Campo vazio/inválido!";
            this.lblUsuarioInvalido.Visible = false;
            // 
            // lblSenhaInvalida
            // 
            this.lblSenhaInvalida.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSenhaInvalida.ForeColor = System.Drawing.Color.Red;
            this.lblSenhaInvalida.Location = new System.Drawing.Point(348, 150);
            this.lblSenhaInvalida.Name = "lblSenhaInvalida";
            this.lblSenhaInvalida.Size = new System.Drawing.Size(131, 15);
            this.lblSenhaInvalida.TabIndex = 6;
            this.lblSenhaInvalida.Text = "Campo vazio/inválido!";
            this.lblSenhaInvalida.Visible = false;
            // 
            // buttonCustom1
            // 
            this.buttonCustom1.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCustom1.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.buttonCustom1.BorderColor = System.Drawing.Color.LavenderBlush;
            this.buttonCustom1.BorderRadius = 17;
            this.buttonCustom1.BorderSize = 2;
            this.buttonCustom1.FlatAppearance.BorderSize = 0;
            this.buttonCustom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCustom1.ForeColor = System.Drawing.Color.White;
            this.buttonCustom1.Location = new System.Drawing.Point(81, 198);
            this.buttonCustom1.Name = "buttonCustom1";
            this.buttonCustom1.Size = new System.Drawing.Size(106, 35);
            this.buttonCustom1.TabIndex = 8;
            this.buttonCustom1.Text = "Cadastrar";
            this.buttonCustom1.TextColor = System.Drawing.Color.White;
            this.buttonCustom1.UseVisualStyleBackColor = false;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(511, 354);
            this.Controls.Add(this.lblSenhaInvalida);
            this.Controls.Add(this.lblUsuarioInvalido);
            this.Controls.Add(this.chkSalvar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_CapVersao);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.lbl_CapLogin);
            this.Controls.Add(this.pnl_BackGroundParcial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Login";
            this.pnl_BackGroundParcial.ResumeLayout(false);
            this.pnl_BackGroundParcial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erroCampos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnl_BackGroundParcial;
        private Button btn_Cadastrar;
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
        private Controls.ButtonCustom buttonCustom1;
    }
}