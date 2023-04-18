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
            this.lbl_Login = new System.Windows.Forms.Label();
            this.txt_Login = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_ConfirmarSenha = new System.Windows.Forms.Label();
            this.txt_ConfirmarSenha = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login.Location = new System.Drawing.Point(25, 26);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(37, 15);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Login";
            // 
            // txt_Login
            // 
            this.txt_Login.Location = new System.Drawing.Point(25, 44);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(159, 23);
            this.txt_Login.TabIndex = 1;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Senha.Location = new System.Drawing.Point(25, 72);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(40, 15);
            this.lbl_Senha.TabIndex = 0;
            this.lbl_Senha.Text = "Senha";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(25, 90);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(159, 23);
            this.txt_Senha.TabIndex = 1;
            // 
            // lbl_ConfirmarSenha
            // 
            this.lbl_ConfirmarSenha.AutoSize = true;
            this.lbl_ConfirmarSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ConfirmarSenha.Location = new System.Drawing.Point(25, 121);
            this.lbl_ConfirmarSenha.Name = "lbl_ConfirmarSenha";
            this.lbl_ConfirmarSenha.Size = new System.Drawing.Size(96, 15);
            this.lbl_ConfirmarSenha.TabIndex = 0;
            this.lbl_ConfirmarSenha.Text = "Confirmar Senha";
            // 
            // txt_ConfirmarSenha
            // 
            this.txt_ConfirmarSenha.Location = new System.Drawing.Point(25, 139);
            this.txt_ConfirmarSenha.Name = "txt_ConfirmarSenha";
            this.txt_ConfirmarSenha.Size = new System.Drawing.Size(159, 23);
            this.txt_ConfirmarSenha.TabIndex = 1;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cadastrar.Location = new System.Drawing.Point(64, 183);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 2;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            // 
            // Frm_CadastroLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 226);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.txt_ConfirmarSenha);
            this.Controls.Add(this.lbl_ConfirmarSenha);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.lbl_Login);
            this.Name = "Frm_CadastroLogin";
            this.Text = "Cadastro Login";
            this.Load += new System.EventHandler(this.Frm_CadastroLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Login;
        private TextBox txt_Login;
        private Label lbl_Senha;
        private TextBox txt_Senha;
        private Label lbl_ConfirmarSenha;
        private TextBox txt_ConfirmarSenha;
        private Button btn_Cadastrar;
    }
}