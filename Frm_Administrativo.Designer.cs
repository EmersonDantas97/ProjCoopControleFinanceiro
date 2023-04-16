namespace ProjCoopControleFinanceiro
{
    partial class Frm_Administrativo
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
            this.mnstp_Menu = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recebimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstp_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnstp_Menu
            // 
            this.mnstp_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.visualizaçãoToolStripMenuItem});
            this.mnstp_Menu.Location = new System.Drawing.Point(0, 0);
            this.mnstp_Menu.Name = "mnstp_Menu";
            this.mnstp_Menu.Size = new System.Drawing.Size(800, 24);
            this.mnstp_Menu.TabIndex = 0;
            this.mnstp_Menu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contraToolStripMenuItem,
            this.cartãoToolStripMenuItem,
            this.tipoContaToolStripMenuItem,
            this.recebimentoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // contraToolStripMenuItem
            // 
            this.contraToolStripMenuItem.Name = "contraToolStripMenuItem";
            this.contraToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.contraToolStripMenuItem.Text = "Conta";
            this.contraToolStripMenuItem.Click += new System.EventHandler(this.contraToolStripMenuItem_Click);
            // 
            // cartãoToolStripMenuItem
            // 
            this.cartãoToolStripMenuItem.Name = "cartãoToolStripMenuItem";
            this.cartãoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cartãoToolStripMenuItem.Text = "Cartão";
            // 
            // tipoContaToolStripMenuItem
            // 
            this.tipoContaToolStripMenuItem.Name = "tipoContaToolStripMenuItem";
            this.tipoContaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.tipoContaToolStripMenuItem.Text = "Tipo Conta";
            // 
            // recebimentoToolStripMenuItem
            // 
            this.recebimentoToolStripMenuItem.Name = "recebimentoToolStripMenuItem";
            this.recebimentoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.recebimentoToolStripMenuItem.Text = "Recebimento";
            // 
            // visualizaçãoToolStripMenuItem
            // 
            this.visualizaçãoToolStripMenuItem.Name = "visualizaçãoToolStripMenuItem";
            this.visualizaçãoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.visualizaçãoToolStripMenuItem.Text = "Visualização";
            // 
            // Frm_Administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnstp_Menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnstp_Menu;
            this.Name = "Frm_Administrativo";
            this.Text = "Controle Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnstp_Menu.ResumeLayout(false);
            this.mnstp_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mnstp_Menu;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem contraToolStripMenuItem;
        private ToolStripMenuItem visualizaçãoToolStripMenuItem;
        private ToolStripMenuItem cartãoToolStripMenuItem;
        private ToolStripMenuItem tipoContaToolStripMenuItem;
        private ToolStripMenuItem recebimentoToolStripMenuItem;
    }
}