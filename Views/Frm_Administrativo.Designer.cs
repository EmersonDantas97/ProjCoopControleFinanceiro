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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Administrativo));
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
            mnstp_Menu.Size = new Size(800, 92);
            mnstp_Menu.TabIndex = 0;
            mnstp_Menu.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contraToolStripMenuItem, cartãoToolStripMenuItem, tipoContaToolStripMenuItem, recebimentoToolStripMenuItem });
            cadastrosToolStripMenuItem.Image = (Image)resources.GetObject("cadastrosToolStripMenuItem.Image");
            cadastrosToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            cadastrosToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Padding = new Padding(10);
            cadastrosToolStripMenuItem.Size = new Size(88, 88);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            cadastrosToolStripMenuItem.TextAlign = ContentAlignment.BottomCenter;
            cadastrosToolStripMenuItem.TextImageRelation = TextImageRelation.Overlay;
            // 
            // contraToolStripMenuItem
            // 
            contraToolStripMenuItem.Image = (Image)resources.GetObject("contraToolStripMenuItem.Image");
            contraToolStripMenuItem.Name = "contraToolStripMenuItem";
            contraToolStripMenuItem.Size = new Size(144, 22);
            contraToolStripMenuItem.Text = "Conta";
            // 
            // cartãoToolStripMenuItem
            // 
            cartãoToolStripMenuItem.Image = (Image)resources.GetObject("cartãoToolStripMenuItem.Image");
            cartãoToolStripMenuItem.Name = "cartãoToolStripMenuItem";
            cartãoToolStripMenuItem.Size = new Size(144, 22);
            cartãoToolStripMenuItem.Text = "Cartão";
            // 
            // tipoContaToolStripMenuItem
            // 
            tipoContaToolStripMenuItem.Image = (Image)resources.GetObject("tipoContaToolStripMenuItem.Image");
            tipoContaToolStripMenuItem.Name = "tipoContaToolStripMenuItem";
            tipoContaToolStripMenuItem.Size = new Size(144, 22);
            tipoContaToolStripMenuItem.Text = "Tipo Conta";
            // 
            // recebimentoToolStripMenuItem
            // 
            recebimentoToolStripMenuItem.Image = (Image)resources.GetObject("recebimentoToolStripMenuItem.Image");
            recebimentoToolStripMenuItem.Name = "recebimentoToolStripMenuItem";
            recebimentoToolStripMenuItem.Size = new Size(144, 22);
            recebimentoToolStripMenuItem.Text = "Recebimento";
            // 
            // visualizaçãoToolStripMenuItem
            // 
            visualizaçãoToolStripMenuItem.Image = (Image)resources.GetObject("visualizaçãoToolStripMenuItem.Image");
            visualizaçãoToolStripMenuItem.ImageAlign = ContentAlignment.TopCenter;
            visualizaçãoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            visualizaçãoToolStripMenuItem.Name = "visualizaçãoToolStripMenuItem";
            visualizaçãoToolStripMenuItem.Size = new Size(83, 88);
            visualizaçãoToolStripMenuItem.Text = "Visualização";
            visualizaçãoToolStripMenuItem.TextAlign = ContentAlignment.BottomCenter;
            visualizaçãoToolStripMenuItem.TextImageRelation = TextImageRelation.Overlay;
            // 
            // Frm_Administrativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnstp_Menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
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