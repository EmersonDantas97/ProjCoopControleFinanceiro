namespace ProjCoopControleFinanceiro
{
    partial class Frm_CadastroLogin
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
            lbl_Login = new Label();
            txt_Login = new TextBox();
            lbl_Senha = new Label();
            txt_Senha = new TextBox();
            lbl_ConfirmarSenha = new Label();
            txt_ConfirmarSenha = new TextBox();
            btn_Cadastrar = new Button();
            lblUsuarioInvalido = new Label();
            lblSenhaInvalida = new Label();
            lblConfirmarInvalida = new Label();
            SuspendLayout();
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Login.Location = new Point(25, 26);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(37, 15);
            lbl_Login.TabIndex = 0;
            lbl_Login.Text = "Login";
            // 
            // txt_Login
            // 
            txt_Login.Location = new Point(25, 44);
            txt_Login.Name = "txt_Login";
            txt_Login.Size = new Size(205, 23);
            txt_Login.TabIndex = 0;
            txt_Login.Validating += txt_Login_Validating;
            // 
            // lbl_Senha
            // 
            lbl_Senha.AutoSize = true;
            lbl_Senha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Senha.Location = new Point(25, 72);
            lbl_Senha.Name = "lbl_Senha";
            lbl_Senha.Size = new Size(40, 15);
            lbl_Senha.TabIndex = 0;
            lbl_Senha.Text = "Senha";
            // 
            // txt_Senha
            // 
            txt_Senha.Location = new Point(25, 90);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.Size = new Size(205, 23);
            txt_Senha.TabIndex = 1;
            txt_Senha.UseSystemPasswordChar = true;
            txt_Senha.Validating += txt_Senha_Validating;
            // 
            // lbl_ConfirmarSenha
            // 
            lbl_ConfirmarSenha.AutoSize = true;
            lbl_ConfirmarSenha.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ConfirmarSenha.Location = new Point(25, 121);
            lbl_ConfirmarSenha.Name = "lbl_ConfirmarSenha";
            lbl_ConfirmarSenha.Size = new Size(60, 15);
            lbl_ConfirmarSenha.TabIndex = 0;
            lbl_ConfirmarSenha.Text = "Confirmar";
            // 
            // txt_ConfirmarSenha
            // 
            txt_ConfirmarSenha.Location = new Point(25, 139);
            txt_ConfirmarSenha.Name = "txt_ConfirmarSenha";
            txt_ConfirmarSenha.Size = new Size(205, 23);
            txt_ConfirmarSenha.TabIndex = 2;
            txt_ConfirmarSenha.UseSystemPasswordChar = true;
            txt_ConfirmarSenha.Validating += txt_ConfirmarSenha_Validating;
            // 
            // btn_Cadastrar
            // 
            btn_Cadastrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cadastrar.Location = new Point(155, 168);
            btn_Cadastrar.Name = "btn_Cadastrar";
            btn_Cadastrar.Size = new Size(75, 23);
            btn_Cadastrar.TabIndex = 3;
            btn_Cadastrar.Text = "Cadastrar";
            btn_Cadastrar.UseVisualStyleBackColor = true;
            btn_Cadastrar.Click += btn_Cadastrar_Click;
            // 
            // lblUsuarioInvalido
            // 
            lblUsuarioInvalido.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuarioInvalido.ForeColor = Color.Red;
            lblUsuarioInvalido.Location = new Point(99, 26);
            lblUsuarioInvalido.Name = "lblUsuarioInvalido";
            lblUsuarioInvalido.Size = new Size(131, 15);
            lblUsuarioInvalido.TabIndex = 7;
            lblUsuarioInvalido.Text = "Campo vazio/inválido!";
            lblUsuarioInvalido.Visible = false;
            // 
            // lblSenhaInvalida
            // 
            lblSenhaInvalida.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSenhaInvalida.ForeColor = Color.Red;
            lblSenhaInvalida.Location = new Point(99, 72);
            lblSenhaInvalida.Name = "lblSenhaInvalida";
            lblSenhaInvalida.Size = new Size(131, 15);
            lblSenhaInvalida.TabIndex = 8;
            lblSenhaInvalida.Text = "Campo vazio/inválido!";
            lblSenhaInvalida.Visible = false;
            // 
            // lblConfirmarInvalida
            // 
            lblConfirmarInvalida.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmarInvalida.ForeColor = Color.Red;
            lblConfirmarInvalida.Location = new Point(99, 121);
            lblConfirmarInvalida.Name = "lblConfirmarInvalida";
            lblConfirmarInvalida.Size = new Size(131, 15);
            lblConfirmarInvalida.TabIndex = 9;
            lblConfirmarInvalida.Text = "Campo vazio/inválido!";
            lblConfirmarInvalida.Visible = false;
            // 
            // Frm_CadastroLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 207);
            Controls.Add(lblConfirmarInvalida);
            Controls.Add(lblSenhaInvalida);
            Controls.Add(lblUsuarioInvalido);
            Controls.Add(btn_Cadastrar);
            Controls.Add(txt_ConfirmarSenha);
            Controls.Add(lbl_ConfirmarSenha);
            Controls.Add(txt_Senha);
            Controls.Add(lbl_Senha);
            Controls.Add(txt_Login);
            Controls.Add(lbl_Login);
            Name = "Frm_CadastroLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Login";
            Load += Frm_CadastroLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Login;
        private TextBox txt_Login;
        private Label lbl_Senha;
        private TextBox txt_Senha;
        private Label lbl_ConfirmarSenha;
        private TextBox txt_ConfirmarSenha;
        private Button btn_Cadastrar;
        private Label lblUsuarioInvalido;
        private Label lblSenhaInvalida;
        private Label lblConfirmarInvalida;
    }
}