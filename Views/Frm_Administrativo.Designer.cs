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
            mnstp_Menu = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            contraToolStripMenuItem = new ToolStripMenuItem();
            cartãoToolStripMenuItem = new ToolStripMenuItem();
            tipoContaToolStripMenuItem = new ToolStripMenuItem();
            recebimentoToolStripMenuItem = new ToolStripMenuItem();
            visualizaçãoToolStripMenuItem = new ToolStripMenuItem();
            mnstp_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // mnstp_Menu
            // 
            mnstp_Menu.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, visualizaçãoToolStripMenuItem });
            mnstp_Menu.Location = new Point(0, 0);
            mnstp_Menu.Name = "mnstp_Menu";
            mnstp_Menu.Size = new Size(800, 24);
            mnstp_Menu.TabIndex = 0;
            mnstp_Menu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contraToolStripMenuItem, cartãoToolStripMenuItem, tipoContaToolStripMenuItem, recebimentoToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // contraToolStripMenuItem
            // 
            contraToolStripMenuItem.Name = "contraToolStripMenuItem";
            contraToolStripMenuItem.Size = new Size(144, 22);
            contraToolStripMenuItem.Text = "Conta";
            contraToolStripMenuItem.Click += contraToolStripMenuItem_Click;
            // 
            // cartãoToolStripMenuItem
            // 
            cartãoToolStripMenuItem.Name = "cartãoToolStripMenuItem";
            cartãoToolStripMenuItem.Size = new Size(144, 22);
            cartãoToolStripMenuItem.Text = "Cartão";
            // 
            // tipoContaToolStripMenuItem
            // 
            tipoContaToolStripMenuItem.Name = "tipoContaToolStripMenuItem";
            tipoContaToolStripMenuItem.Size = new Size(144, 22);
            tipoContaToolStripMenuItem.Text = "Tipo Conta";
            // 
            // recebimentoToolStripMenuItem
            // 
            recebimentoToolStripMenuItem.Name = "recebimentoToolStripMenuItem";
            recebimentoToolStripMenuItem.Size = new Size(144, 22);
            recebimentoToolStripMenuItem.Text = "Recebimento";
            // 
            // visualizaçãoToolStripMenuItem
            // 
            visualizaçãoToolStripMenuItem.Name = "visualizaçãoToolStripMenuItem";
            visualizaçãoToolStripMenuItem.Size = new Size(83, 20);
            visualizaçãoToolStripMenuItem.Text = "Visualização";
            // 
            // Frm_Administrativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnstp_Menu);
            IsMdiContainer = true;
            MainMenuStrip = mnstp_Menu;
            Name = "Frm_Administrativo";
            Text = "Controle Financeiro";
            WindowState = FormWindowState.Maximized;
            FormClosing += Frm_Administrativo_FormClosing;
            mnstp_Menu.ResumeLayout(false);
            mnstp_Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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