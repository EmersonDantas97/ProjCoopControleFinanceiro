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
            this.mnstp_Menu.Size = new System.Drawing.Size(800, 92);
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
            this.cadastrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrosToolStripMenuItem.Image")));
            this.cadastrosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cadastrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10);
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(88, 88);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            this.cadastrosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cadastrosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // contraToolStripMenuItem
            // 
            this.contraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("contraToolStripMenuItem.Image")));
            this.contraToolStripMenuItem.Name = "contraToolStripMenuItem";
            this.contraToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.contraToolStripMenuItem.Text = "Conta";
            // 
            // cartãoToolStripMenuItem
            // 
            this.cartãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cartãoToolStripMenuItem.Image")));
            this.cartãoToolStripMenuItem.Name = "cartãoToolStripMenuItem";
            this.cartãoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cartãoToolStripMenuItem.Text = "Cartão";
            // 
            // tipoContaToolStripMenuItem
            // 
            this.tipoContaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tipoContaToolStripMenuItem.Image")));
            this.tipoContaToolStripMenuItem.Name = "tipoContaToolStripMenuItem";
            this.tipoContaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.tipoContaToolStripMenuItem.Text = "Tipo Conta";
            // 
            // recebimentoToolStripMenuItem
            // 
            this.recebimentoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recebimentoToolStripMenuItem.Image")));
            this.recebimentoToolStripMenuItem.Name = "recebimentoToolStripMenuItem";
            this.recebimentoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.recebimentoToolStripMenuItem.Text = "Recebimento";
            // 
            // visualizaçãoToolStripMenuItem
            // 
            this.visualizaçãoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visualizaçãoToolStripMenuItem.Image")));
            this.visualizaçãoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.visualizaçãoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.visualizaçãoToolStripMenuItem.Name = "visualizaçãoToolStripMenuItem";
            this.visualizaçãoToolStripMenuItem.Size = new System.Drawing.Size(83, 88);
            this.visualizaçãoToolStripMenuItem.Text = "Visualização";
            this.visualizaçãoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.visualizaçãoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // Frm_Administrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnstp_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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