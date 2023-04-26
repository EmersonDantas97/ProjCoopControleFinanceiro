namespace ProjCoopControleFinanceiro
{
    partial class Frm_CadastroConta
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
            grp_InfosAutomaticas = new GroupBox();
            txt_DataHora = new TextBox();
            lbl_DataHora = new Label();
            txt_Codigo = new TextBox();
            lbl_Codigo = new Label();
            grp_InfosPrincipais = new GroupBox();
            chk_LancamentoIncerto = new CheckBox();
            chk_PagamentoEfetuado = new CheckBox();
            lbl_TipoPagamento = new Label();
            cmb_TipoPagamento = new ComboBox();
            lbl_Duracao = new Label();
            cmb_Duracao = new ComboBox();
            lbl_Observacao = new Label();
            lbl_TipoConta = new Label();
            cmb_TipoConta = new ComboBox();
            txt_DataEmissao = new TextBox();
            lbl_Emissao = new Label();
            lbl_Nome = new Label();
            txt_DataPagar = new TextBox();
            lbl_Pagar = new Label();
            txt_Valor = new TextBox();
            lbl_Valor = new Label();
            txt_Observacao = new TextBox();
            txt_NomeConta = new TextBox();
            label1 = new Label();
            grp_InfosAdicionais = new GroupBox();
            lbl_Cartao = new Label();
            cmb_Cartao = new ComboBox();
            lbl_QtdParcelas = new Label();
            cmb_QtdParcelas = new ComboBox();
            lbl_ParcelaAtual = new Label();
            cmb_ParcelaAtual = new ComboBox();
            btn_Salvar = new Button();
            btn_Sair = new Button();
            btn_Excluir = new Button();
            btn_Novo = new Button();
            grp_InfosAutomaticas.SuspendLayout();
            grp_InfosPrincipais.SuspendLayout();
            grp_InfosAdicionais.SuspendLayout();
            SuspendLayout();
            // 
            // grp_InfosAutomaticas
            // 
            grp_InfosAutomaticas.Controls.Add(txt_DataHora);
            grp_InfosAutomaticas.Controls.Add(lbl_DataHora);
            grp_InfosAutomaticas.Controls.Add(txt_Codigo);
            grp_InfosAutomaticas.Controls.Add(lbl_Codigo);
            grp_InfosAutomaticas.Location = new Point(12, 1);
            grp_InfosAutomaticas.Name = "grp_InfosAutomaticas";
            grp_InfosAutomaticas.Size = new Size(224, 77);
            grp_InfosAutomaticas.TabIndex = 13;
            grp_InfosAutomaticas.TabStop = false;
            // 
            // txt_DataHora
            // 
            txt_DataHora.BackColor = SystemColors.ControlLight;
            txt_DataHora.BorderStyle = BorderStyle.FixedSingle;
            txt_DataHora.Enabled = false;
            txt_DataHora.Location = new Point(89, 36);
            txt_DataHora.Name = "txt_DataHora";
            txt_DataHora.Size = new Size(117, 23);
            txt_DataHora.TabIndex = 12;
            txt_DataHora.Text = "16/04/2023 18:04:50";
            // 
            // lbl_DataHora
            // 
            lbl_DataHora.AutoSize = true;
            lbl_DataHora.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DataHora.Location = new Point(92, 19);
            lbl_DataHora.Name = "lbl_DataHora";
            lbl_DataHora.Size = new Size(70, 15);
            lbl_DataHora.TabIndex = 11;
            lbl_DataHora.Text = "Data e Hora";
            // 
            // txt_Codigo
            // 
            txt_Codigo.BackColor = SystemColors.ControlLightLight;
            txt_Codigo.BorderStyle = BorderStyle.FixedSingle;
            txt_Codigo.ForeColor = SystemColors.InfoText;
            txt_Codigo.Location = new Point(12, 36);
            txt_Codigo.Name = "txt_Codigo";
            txt_Codigo.Size = new Size(74, 23);
            txt_Codigo.TabIndex = 10;
            txt_Codigo.Text = "000001";
            // 
            // lbl_Codigo
            // 
            lbl_Codigo.AutoSize = true;
            lbl_Codigo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Codigo.Location = new Point(15, 19);
            lbl_Codigo.Name = "lbl_Codigo";
            lbl_Codigo.Size = new Size(45, 15);
            lbl_Codigo.TabIndex = 9;
            lbl_Codigo.Text = "Código";
            // 
            // grp_InfosPrincipais
            // 
            grp_InfosPrincipais.Controls.Add(chk_LancamentoIncerto);
            grp_InfosPrincipais.Controls.Add(chk_PagamentoEfetuado);
            grp_InfosPrincipais.Controls.Add(lbl_TipoPagamento);
            grp_InfosPrincipais.Controls.Add(cmb_TipoPagamento);
            grp_InfosPrincipais.Controls.Add(lbl_Duracao);
            grp_InfosPrincipais.Controls.Add(cmb_Duracao);
            grp_InfosPrincipais.Controls.Add(lbl_Observacao);
            grp_InfosPrincipais.Controls.Add(lbl_TipoConta);
            grp_InfosPrincipais.Controls.Add(cmb_TipoConta);
            grp_InfosPrincipais.Controls.Add(txt_DataEmissao);
            grp_InfosPrincipais.Controls.Add(lbl_Emissao);
            grp_InfosPrincipais.Controls.Add(lbl_Nome);
            grp_InfosPrincipais.Controls.Add(txt_DataPagar);
            grp_InfosPrincipais.Controls.Add(lbl_Pagar);
            grp_InfosPrincipais.Controls.Add(txt_Valor);
            grp_InfosPrincipais.Controls.Add(lbl_Valor);
            grp_InfosPrincipais.Controls.Add(txt_Observacao);
            grp_InfosPrincipais.Controls.Add(txt_NomeConta);
            grp_InfosPrincipais.Controls.Add(label1);
            grp_InfosPrincipais.Location = new Point(12, 78);
            grp_InfosPrincipais.Name = "grp_InfosPrincipais";
            grp_InfosPrincipais.Size = new Size(425, 236);
            grp_InfosPrincipais.TabIndex = 14;
            grp_InfosPrincipais.TabStop = false;
            // 
            // chk_LancamentoIncerto
            // 
            chk_LancamentoIncerto.AutoSize = true;
            chk_LancamentoIncerto.Location = new Point(215, 208);
            chk_LancamentoIncerto.Name = "chk_LancamentoIncerto";
            chk_LancamentoIncerto.Size = new Size(135, 19);
            chk_LancamentoIncerto.TabIndex = 27;
            chk_LancamentoIncerto.Text = "Lançamento incerto.";
            chk_LancamentoIncerto.UseVisualStyleBackColor = true;
            // 
            // chk_PagamentoEfetuado
            // 
            chk_PagamentoEfetuado.AutoSize = true;
            chk_PagamentoEfetuado.Location = new Point(59, 208);
            chk_PagamentoEfetuado.Name = "chk_PagamentoEfetuado";
            chk_PagamentoEfetuado.Size = new Size(152, 19);
            chk_PagamentoEfetuado.TabIndex = 26;
            chk_PagamentoEfetuado.Text = "Pagamento já efetuado.";
            chk_PagamentoEfetuado.UseVisualStyleBackColor = true;
            // 
            // lbl_TipoPagamento
            // 
            lbl_TipoPagamento.AutoSize = true;
            lbl_TipoPagamento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TipoPagamento.Location = new Point(222, 159);
            lbl_TipoPagamento.Name = "lbl_TipoPagamento";
            lbl_TipoPagamento.Size = new Size(95, 15);
            lbl_TipoPagamento.TabIndex = 25;
            lbl_TipoPagamento.Text = "Tipo Pagamento";
            // 
            // cmb_TipoPagamento
            // 
            cmb_TipoPagamento.FormattingEnabled = true;
            cmb_TipoPagamento.Location = new Point(219, 176);
            cmb_TipoPagamento.Name = "cmb_TipoPagamento";
            cmb_TipoPagamento.Size = new Size(191, 23);
            cmb_TipoPagamento.TabIndex = 24;
            cmb_TipoPagamento.Text = "Crédito";
            // 
            // lbl_Duracao
            // 
            lbl_Duracao.AutoSize = true;
            lbl_Duracao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Duracao.Location = new Point(9, 159);
            lbl_Duracao.Name = "lbl_Duracao";
            lbl_Duracao.Size = new Size(52, 15);
            lbl_Duracao.TabIndex = 23;
            lbl_Duracao.Text = "Duração";
            // 
            // cmb_Duracao
            // 
            cmb_Duracao.FormattingEnabled = true;
            cmb_Duracao.Location = new Point(6, 176);
            cmb_Duracao.Name = "cmb_Duracao";
            cmb_Duracao.Size = new Size(210, 23);
            cmb_Duracao.TabIndex = 22;
            cmb_Duracao.Text = "Fixa";
            // 
            // lbl_Observacao
            // 
            lbl_Observacao.AutoSize = true;
            lbl_Observacao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Observacao.Location = new Point(9, 112);
            lbl_Observacao.Name = "lbl_Observacao";
            lbl_Observacao.Size = new Size(69, 15);
            lbl_Observacao.TabIndex = 21;
            lbl_Observacao.Text = "Observação";
            // 
            // lbl_TipoConta
            // 
            lbl_TipoConta.AutoSize = true;
            lbl_TipoConta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TipoConta.Location = new Point(9, 67);
            lbl_TipoConta.Name = "lbl_TipoConta";
            lbl_TipoConta.Size = new Size(65, 15);
            lbl_TipoConta.TabIndex = 21;
            lbl_TipoConta.Text = "Tipo Conta";
            // 
            // cmb_TipoConta
            // 
            cmb_TipoConta.FormattingEnabled = true;
            cmb_TipoConta.Location = new Point(6, 84);
            cmb_TipoConta.Name = "cmb_TipoConta";
            cmb_TipoConta.Size = new Size(210, 23);
            cmb_TipoConta.TabIndex = 20;
            cmb_TipoConta.Text = "Mercado";
            // 
            // txt_DataEmissao
            // 
            txt_DataEmissao.BackColor = SystemColors.ControlLightLight;
            txt_DataEmissao.Location = new Point(219, 84);
            txt_DataEmissao.Name = "txt_DataEmissao";
            txt_DataEmissao.Size = new Size(95, 23);
            txt_DataEmissao.TabIndex = 19;
            txt_DataEmissao.Text = "15/06/2023";
            // 
            // lbl_Emissao
            // 
            lbl_Emissao.AutoSize = true;
            lbl_Emissao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Emissao.Location = new Point(222, 67);
            lbl_Emissao.Name = "lbl_Emissao";
            lbl_Emissao.Size = new Size(50, 15);
            lbl_Emissao.TabIndex = 18;
            lbl_Emissao.Text = "Emissão";
            // 
            // lbl_Nome
            // 
            lbl_Nome.AutoSize = true;
            lbl_Nome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Nome.Location = new Point(9, 21);
            lbl_Nome.Name = "lbl_Nome";
            lbl_Nome.Size = new Size(40, 15);
            lbl_Nome.TabIndex = 17;
            lbl_Nome.Text = "Nome";
            // 
            // txt_DataPagar
            // 
            txt_DataPagar.BackColor = SystemColors.ControlLightLight;
            txt_DataPagar.Location = new Point(317, 84);
            txt_DataPagar.Name = "txt_DataPagar";
            txt_DataPagar.Size = new Size(95, 23);
            txt_DataPagar.TabIndex = 16;
            txt_DataPagar.Text = "15/06/2023";
            // 
            // lbl_Pagar
            // 
            lbl_Pagar.AutoSize = true;
            lbl_Pagar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Pagar.Location = new Point(320, 67);
            lbl_Pagar.Name = "lbl_Pagar";
            lbl_Pagar.Size = new Size(37, 15);
            lbl_Pagar.TabIndex = 15;
            lbl_Pagar.Text = "Pagar";
            // 
            // txt_Valor
            // 
            txt_Valor.BackColor = SystemColors.ControlLightLight;
            txt_Valor.Location = new Point(320, 38);
            txt_Valor.Name = "txt_Valor";
            txt_Valor.Size = new Size(95, 23);
            txt_Valor.TabIndex = 16;
            txt_Valor.Text = "R$ 1.032,57";
            // 
            // lbl_Valor
            // 
            lbl_Valor.AutoSize = true;
            lbl_Valor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Valor.Location = new Point(323, 21);
            lbl_Valor.Name = "lbl_Valor";
            lbl_Valor.Size = new Size(34, 15);
            lbl_Valor.TabIndex = 15;
            lbl_Valor.Text = "Valor";
            // 
            // txt_Observacao
            // 
            txt_Observacao.BackColor = SystemColors.ControlLightLight;
            txt_Observacao.Location = new Point(6, 129);
            txt_Observacao.Name = "txt_Observacao";
            txt_Observacao.Size = new Size(410, 23);
            txt_Observacao.TabIndex = 14;
            txt_Observacao.Text = "Frutas, verduras, macarrão.";
            // 
            // txt_NomeConta
            // 
            txt_NomeConta.BackColor = SystemColors.ControlLightLight;
            txt_NomeConta.Location = new Point(6, 38);
            txt_NomeConta.Name = "txt_NomeConta";
            txt_NomeConta.Size = new Size(311, 23);
            txt_NomeConta.TabIndex = 14;
            txt_NomeConta.Text = "Compra do Mês";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-103, 30);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 13;
            label1.Text = "Nome";
            // 
            // grp_InfosAdicionais
            // 
            grp_InfosAdicionais.Controls.Add(lbl_Cartao);
            grp_InfosAdicionais.Controls.Add(cmb_Cartao);
            grp_InfosAdicionais.Controls.Add(lbl_QtdParcelas);
            grp_InfosAdicionais.Controls.Add(cmb_QtdParcelas);
            grp_InfosAdicionais.Controls.Add(lbl_ParcelaAtual);
            grp_InfosAdicionais.Controls.Add(cmb_ParcelaAtual);
            grp_InfosAdicionais.Location = new Point(12, 314);
            grp_InfosAdicionais.Name = "grp_InfosAdicionais";
            grp_InfosAdicionais.Size = new Size(425, 71);
            grp_InfosAdicionais.TabIndex = 15;
            grp_InfosAdicionais.TabStop = false;
            // 
            // lbl_Cartao
            // 
            lbl_Cartao.AutoSize = true;
            lbl_Cartao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Cartao.Location = new Point(182, 19);
            lbl_Cartao.Name = "lbl_Cartao";
            lbl_Cartao.Size = new Size(41, 15);
            lbl_Cartao.TabIndex = 27;
            lbl_Cartao.Text = "Cartão";
            // 
            // cmb_Cartao
            // 
            cmb_Cartao.FormattingEnabled = true;
            cmb_Cartao.Location = new Point(179, 36);
            cmb_Cartao.Name = "cmb_Cartao";
            cmb_Cartao.Size = new Size(232, 23);
            cmb_Cartao.TabIndex = 26;
            cmb_Cartao.Text = "NU Bank";
            // 
            // lbl_QtdParcelas
            // 
            lbl_QtdParcelas.AutoSize = true;
            lbl_QtdParcelas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_QtdParcelas.Location = new Point(93, 19);
            lbl_QtdParcelas.Name = "lbl_QtdParcelas";
            lbl_QtdParcelas.Size = new Size(79, 15);
            lbl_QtdParcelas.TabIndex = 25;
            lbl_QtdParcelas.Text = "Qtde Parcelas";
            // 
            // cmb_QtdParcelas
            // 
            cmb_QtdParcelas.FormattingEnabled = true;
            cmb_QtdParcelas.Location = new Point(90, 36);
            cmb_QtdParcelas.Name = "cmb_QtdParcelas";
            cmb_QtdParcelas.Size = new Size(86, 23);
            cmb_QtdParcelas.TabIndex = 24;
            cmb_QtdParcelas.Text = "10";
            // 
            // lbl_ParcelaAtual
            // 
            lbl_ParcelaAtual.AutoSize = true;
            lbl_ParcelaAtual.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ParcelaAtual.Location = new Point(9, 19);
            lbl_ParcelaAtual.Name = "lbl_ParcelaAtual";
            lbl_ParcelaAtual.Size = new Size(76, 15);
            lbl_ParcelaAtual.TabIndex = 23;
            lbl_ParcelaAtual.Text = "Parcela Atual";
            // 
            // cmb_ParcelaAtual
            // 
            cmb_ParcelaAtual.FormattingEnabled = true;
            cmb_ParcelaAtual.Location = new Point(6, 36);
            cmb_ParcelaAtual.Name = "cmb_ParcelaAtual";
            cmb_ParcelaAtual.Size = new Size(81, 23);
            cmb_ParcelaAtual.TabIndex = 22;
            cmb_ParcelaAtual.Text = "1";
            // 
            // btn_Salvar
            // 
            btn_Salvar.Location = new Point(249, 17);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(87, 23);
            btn_Salvar.TabIndex = 16;
            btn_Salvar.Text = "F1 - Salvar";
            btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // btn_Sair
            // 
            btn_Sair.Location = new Point(249, 45);
            btn_Sair.Name = "btn_Sair";
            btn_Sair.Size = new Size(87, 23);
            btn_Sair.TabIndex = 17;
            btn_Sair.Text = "F4 - Sair";
            btn_Sair.UseVisualStyleBackColor = true;
            // 
            // btn_Excluir
            // 
            btn_Excluir.Location = new Point(341, 45);
            btn_Excluir.Name = "btn_Excluir";
            btn_Excluir.Size = new Size(87, 23);
            btn_Excluir.TabIndex = 19;
            btn_Excluir.Text = "F3 - Excluir";
            btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // btn_Novo
            // 
            btn_Novo.Location = new Point(341, 17);
            btn_Novo.Name = "btn_Novo";
            btn_Novo.Size = new Size(87, 23);
            btn_Novo.TabIndex = 18;
            btn_Novo.Text = "F2 - Novo";
            btn_Novo.UseVisualStyleBackColor = true;
            // 
            // Frm_CadastroConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(449, 397);
            Controls.Add(btn_Excluir);
            Controls.Add(btn_Novo);
            Controls.Add(btn_Sair);
            Controls.Add(btn_Salvar);
            Controls.Add(grp_InfosAdicionais);
            Controls.Add(grp_InfosPrincipais);
            Controls.Add(grp_InfosAutomaticas);
            Name = "Frm_CadastroConta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Conta";
            grp_InfosAutomaticas.ResumeLayout(false);
            grp_InfosAutomaticas.PerformLayout();
            grp_InfosPrincipais.ResumeLayout(false);
            grp_InfosPrincipais.PerformLayout();
            grp_InfosAdicionais.ResumeLayout(false);
            grp_InfosAdicionais.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_InfosAutomaticas;
        private TextBox txt_DataHora;
        private Label lbl_DataHora;
        private TextBox txt_Codigo;
        private Label lbl_Codigo;
        private GroupBox grp_InfosPrincipais;
        private Label lbl_Nome;
        private TextBox txt_Valor;
        private Label lbl_Valor;
        private TextBox txt_NomeConta;
        private Label label1;
        private Label lbl_TipoPagamento;
        private ComboBox cmb_TipoPagamento;
        private Label lbl_Duracao;
        private ComboBox cmb_Duracao;
        private Label lbl_Observacao;
        private Label lbl_TipoConta;
        private ComboBox cmb_TipoConta;
        private TextBox txt_DataEmissao;
        private Label lbl_Emissao;
        private TextBox txt_DataPagar;
        private Label lbl_Pagar;
        private TextBox txt_Observacao;
        private CheckBox chk_LancamentoIncerto;
        private CheckBox chk_PagamentoEfetuado;
        private GroupBox grp_InfosAdicionais;
        private Label lbl_Cartao;
        private ComboBox cmb_Cartao;
        private Label lbl_QtdParcelas;
        private ComboBox cmb_QtdParcelas;
        private Label lbl_ParcelaAtual;
        private ComboBox cmb_ParcelaAtual;
        private Button btn_Salvar;
        private Button btn_Sair;
        private Button btn_Excluir;
        private Button btn_Novo;
    }
}