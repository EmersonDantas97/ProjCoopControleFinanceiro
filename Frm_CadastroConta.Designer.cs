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
            this.grp_InfosAutomaticas = new System.Windows.Forms.GroupBox();
            this.txt_DataHora = new System.Windows.Forms.TextBox();
            this.lbl_DataHora = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.grp_InfosPrincipais = new System.Windows.Forms.GroupBox();
            this.chk_LancamentoIncerto = new System.Windows.Forms.CheckBox();
            this.chk_PagamentoEfetuado = new System.Windows.Forms.CheckBox();
            this.lbl_TipoPagamento = new System.Windows.Forms.Label();
            this.cmb_TipoPagamento = new System.Windows.Forms.ComboBox();
            this.lbl_Duracao = new System.Windows.Forms.Label();
            this.cmb_Duracao = new System.Windows.Forms.ComboBox();
            this.lbl_Observacao = new System.Windows.Forms.Label();
            this.lbl_TipoConta = new System.Windows.Forms.Label();
            this.cmb_TipoConta = new System.Windows.Forms.ComboBox();
            this.txt_DataEmissao = new System.Windows.Forms.TextBox();
            this.lbl_Emissao = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_DataPagar = new System.Windows.Forms.TextBox();
            this.lbl_Pagar = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_Valor = new System.Windows.Forms.Label();
            this.txt_Observacao = new System.Windows.Forms.TextBox();
            this.txt_NomeConta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_InfosAdicionais = new System.Windows.Forms.GroupBox();
            this.lbl_Cartao = new System.Windows.Forms.Label();
            this.cmb_Cartao = new System.Windows.Forms.ComboBox();
            this.lbl_QtdParcelas = new System.Windows.Forms.Label();
            this.cmb_QtdParcelas = new System.Windows.Forms.ComboBox();
            this.lbl_ParcelaAtual = new System.Windows.Forms.Label();
            this.cmb_ParcelaAtual = new System.Windows.Forms.ComboBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.grp_InfosAutomaticas.SuspendLayout();
            this.grp_InfosPrincipais.SuspendLayout();
            this.grp_InfosAdicionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_InfosAutomaticas
            // 
            this.grp_InfosAutomaticas.Controls.Add(this.txt_DataHora);
            this.grp_InfosAutomaticas.Controls.Add(this.lbl_DataHora);
            this.grp_InfosAutomaticas.Controls.Add(this.txt_Codigo);
            this.grp_InfosAutomaticas.Controls.Add(this.lbl_Codigo);
            this.grp_InfosAutomaticas.Location = new System.Drawing.Point(12, 1);
            this.grp_InfosAutomaticas.Name = "grp_InfosAutomaticas";
            this.grp_InfosAutomaticas.Size = new System.Drawing.Size(224, 77);
            this.grp_InfosAutomaticas.TabIndex = 13;
            this.grp_InfosAutomaticas.TabStop = false;
            // 
            // txt_DataHora
            // 
            this.txt_DataHora.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_DataHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DataHora.Enabled = false;
            this.txt_DataHora.Location = new System.Drawing.Point(89, 36);
            this.txt_DataHora.Name = "txt_DataHora";
            this.txt_DataHora.Size = new System.Drawing.Size(117, 23);
            this.txt_DataHora.TabIndex = 12;
            this.txt_DataHora.Text = "16/04/2023 18:04:50";
            // 
            // lbl_DataHora
            // 
            this.lbl_DataHora.AutoSize = true;
            this.lbl_DataHora.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DataHora.Location = new System.Drawing.Point(92, 19);
            this.lbl_DataHora.Name = "lbl_DataHora";
            this.lbl_DataHora.Size = new System.Drawing.Size(70, 15);
            this.lbl_DataHora.TabIndex = 11;
            this.lbl_DataHora.Text = "Data e Hora";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Codigo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_Codigo.Location = new System.Drawing.Point(12, 36);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(74, 23);
            this.txt_Codigo.TabIndex = 10;
            this.txt_Codigo.Text = "000001";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Codigo.Location = new System.Drawing.Point(15, 19);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(45, 15);
            this.lbl_Codigo.TabIndex = 9;
            this.lbl_Codigo.Text = "Código";
            // 
            // grp_InfosPrincipais
            // 
            this.grp_InfosPrincipais.Controls.Add(this.chk_LancamentoIncerto);
            this.grp_InfosPrincipais.Controls.Add(this.chk_PagamentoEfetuado);
            this.grp_InfosPrincipais.Controls.Add(this.lbl_TipoPagamento);
            this.grp_InfosPrincipais.Controls.Add(this.cmb_TipoPagamento);
            this.grp_InfosPrincipais.Controls.Add(this.lbl_Duracao);
            this.grp_InfosPrincipais.Controls.Add(this.cmb_Duracao);
            this.grp_InfosPrincipais.Controls.Add(this.lbl_Observacao);
            this.grp_InfosPrincipais.Controls.Add(this.lbl_TipoConta);
            this.grp_InfosPrincipais.Controls.Add(this.cmb_TipoConta);
            this.grp_InfosPrincipais.Controls.Add(this.txt_DataEmissao);
            this.grp_InfosPrincipais.Controls.Add(this.lbl_Emissao);
            this.grp_InfosPrincipais.Controls.Add(this.lbl_Nome);
            this.grp_InfosPrincipais.Controls.Add(this.txt_DataPagar);
            this.grp_InfosPrincipais.Controls.Add(this.lbl_Pagar);
            this.grp_InfosPrincipais.Controls.Add(this.txt_Valor);
            this.grp_InfosPrincipais.Controls.Add(this.lbl_Valor);
            this.grp_InfosPrincipais.Controls.Add(this.txt_Observacao);
            this.grp_InfosPrincipais.Controls.Add(this.txt_NomeConta);
            this.grp_InfosPrincipais.Controls.Add(this.label1);
            this.grp_InfosPrincipais.Location = new System.Drawing.Point(12, 78);
            this.grp_InfosPrincipais.Name = "grp_InfosPrincipais";
            this.grp_InfosPrincipais.Size = new System.Drawing.Size(425, 236);
            this.grp_InfosPrincipais.TabIndex = 14;
            this.grp_InfosPrincipais.TabStop = false;
            // 
            // chk_LancamentoIncerto
            // 
            this.chk_LancamentoIncerto.AutoSize = true;
            this.chk_LancamentoIncerto.Location = new System.Drawing.Point(215, 208);
            this.chk_LancamentoIncerto.Name = "chk_LancamentoIncerto";
            this.chk_LancamentoIncerto.Size = new System.Drawing.Size(135, 19);
            this.chk_LancamentoIncerto.TabIndex = 27;
            this.chk_LancamentoIncerto.Text = "Lançamento incerto.";
            this.chk_LancamentoIncerto.UseVisualStyleBackColor = true;
            // 
            // chk_PagamentoEfetuado
            // 
            this.chk_PagamentoEfetuado.AutoSize = true;
            this.chk_PagamentoEfetuado.Location = new System.Drawing.Point(59, 208);
            this.chk_PagamentoEfetuado.Name = "chk_PagamentoEfetuado";
            this.chk_PagamentoEfetuado.Size = new System.Drawing.Size(152, 19);
            this.chk_PagamentoEfetuado.TabIndex = 26;
            this.chk_PagamentoEfetuado.Text = "Pagamento já efetuado.";
            this.chk_PagamentoEfetuado.UseVisualStyleBackColor = true;
            // 
            // lbl_TipoPagamento
            // 
            this.lbl_TipoPagamento.AutoSize = true;
            this.lbl_TipoPagamento.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TipoPagamento.Location = new System.Drawing.Point(222, 159);
            this.lbl_TipoPagamento.Name = "lbl_TipoPagamento";
            this.lbl_TipoPagamento.Size = new System.Drawing.Size(95, 15);
            this.lbl_TipoPagamento.TabIndex = 25;
            this.lbl_TipoPagamento.Text = "Tipo Pagamento";
            // 
            // cmb_TipoPagamento
            // 
            this.cmb_TipoPagamento.FormattingEnabled = true;
            this.cmb_TipoPagamento.Location = new System.Drawing.Point(219, 176);
            this.cmb_TipoPagamento.Name = "cmb_TipoPagamento";
            this.cmb_TipoPagamento.Size = new System.Drawing.Size(191, 23);
            this.cmb_TipoPagamento.TabIndex = 24;
            this.cmb_TipoPagamento.Text = "Crédito";
            // 
            // lbl_Duracao
            // 
            this.lbl_Duracao.AutoSize = true;
            this.lbl_Duracao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Duracao.Location = new System.Drawing.Point(9, 159);
            this.lbl_Duracao.Name = "lbl_Duracao";
            this.lbl_Duracao.Size = new System.Drawing.Size(52, 15);
            this.lbl_Duracao.TabIndex = 23;
            this.lbl_Duracao.Text = "Duração";
            // 
            // cmb_Duracao
            // 
            this.cmb_Duracao.FormattingEnabled = true;
            this.cmb_Duracao.Location = new System.Drawing.Point(6, 176);
            this.cmb_Duracao.Name = "cmb_Duracao";
            this.cmb_Duracao.Size = new System.Drawing.Size(210, 23);
            this.cmb_Duracao.TabIndex = 22;
            this.cmb_Duracao.Text = "Fixa";
            // 
            // lbl_Observacao
            // 
            this.lbl_Observacao.AutoSize = true;
            this.lbl_Observacao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Observacao.Location = new System.Drawing.Point(9, 112);
            this.lbl_Observacao.Name = "lbl_Observacao";
            this.lbl_Observacao.Size = new System.Drawing.Size(69, 15);
            this.lbl_Observacao.TabIndex = 21;
            this.lbl_Observacao.Text = "Observação";
            // 
            // lbl_TipoConta
            // 
            this.lbl_TipoConta.AutoSize = true;
            this.lbl_TipoConta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TipoConta.Location = new System.Drawing.Point(9, 67);
            this.lbl_TipoConta.Name = "lbl_TipoConta";
            this.lbl_TipoConta.Size = new System.Drawing.Size(65, 15);
            this.lbl_TipoConta.TabIndex = 21;
            this.lbl_TipoConta.Text = "Tipo Conta";
            // 
            // cmb_TipoConta
            // 
            this.cmb_TipoConta.FormattingEnabled = true;
            this.cmb_TipoConta.Location = new System.Drawing.Point(6, 84);
            this.cmb_TipoConta.Name = "cmb_TipoConta";
            this.cmb_TipoConta.Size = new System.Drawing.Size(210, 23);
            this.cmb_TipoConta.TabIndex = 20;
            this.cmb_TipoConta.Text = "Mercado";
            // 
            // txt_DataEmissao
            // 
            this.txt_DataEmissao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_DataEmissao.Location = new System.Drawing.Point(219, 84);
            this.txt_DataEmissao.Name = "txt_DataEmissao";
            this.txt_DataEmissao.Size = new System.Drawing.Size(95, 23);
            this.txt_DataEmissao.TabIndex = 19;
            this.txt_DataEmissao.Text = "15/06/2023";
            // 
            // lbl_Emissao
            // 
            this.lbl_Emissao.AutoSize = true;
            this.lbl_Emissao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Emissao.Location = new System.Drawing.Point(222, 67);
            this.lbl_Emissao.Name = "lbl_Emissao";
            this.lbl_Emissao.Size = new System.Drawing.Size(50, 15);
            this.lbl_Emissao.TabIndex = 18;
            this.lbl_Emissao.Text = "Emissão";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(9, 21);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(40, 15);
            this.lbl_Nome.TabIndex = 17;
            this.lbl_Nome.Text = "Nome";
            // 
            // txt_DataPagar
            // 
            this.txt_DataPagar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_DataPagar.Location = new System.Drawing.Point(317, 84);
            this.txt_DataPagar.Name = "txt_DataPagar";
            this.txt_DataPagar.Size = new System.Drawing.Size(95, 23);
            this.txt_DataPagar.TabIndex = 16;
            this.txt_DataPagar.Text = "15/06/2023";
            // 
            // lbl_Pagar
            // 
            this.lbl_Pagar.AutoSize = true;
            this.lbl_Pagar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pagar.Location = new System.Drawing.Point(320, 67);
            this.lbl_Pagar.Name = "lbl_Pagar";
            this.lbl_Pagar.Size = new System.Drawing.Size(37, 15);
            this.lbl_Pagar.TabIndex = 15;
            this.lbl_Pagar.Text = "Pagar";
            // 
            // txt_Valor
            // 
            this.txt_Valor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Valor.Location = new System.Drawing.Point(320, 38);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(95, 23);
            this.txt_Valor.TabIndex = 16;
            this.txt_Valor.Text = "R$ 1.032,57";
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Valor.Location = new System.Drawing.Point(323, 21);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(34, 15);
            this.lbl_Valor.TabIndex = 15;
            this.lbl_Valor.Text = "Valor";
            // 
            // txt_Observacao
            // 
            this.txt_Observacao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Observacao.Location = new System.Drawing.Point(6, 129);
            this.txt_Observacao.Name = "txt_Observacao";
            this.txt_Observacao.Size = new System.Drawing.Size(410, 23);
            this.txt_Observacao.TabIndex = 14;
            this.txt_Observacao.Text = "Frutas, verduras, macarrão.";
            // 
            // txt_NomeConta
            // 
            this.txt_NomeConta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_NomeConta.Location = new System.Drawing.Point(6, 38);
            this.txt_NomeConta.Name = "txt_NomeConta";
            this.txt_NomeConta.Size = new System.Drawing.Size(311, 23);
            this.txt_NomeConta.TabIndex = 14;
            this.txt_NomeConta.Text = "Compra do Mês";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-103, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // grp_InfosAdicionais
            // 
            this.grp_InfosAdicionais.Controls.Add(this.lbl_Cartao);
            this.grp_InfosAdicionais.Controls.Add(this.cmb_Cartao);
            this.grp_InfosAdicionais.Controls.Add(this.lbl_QtdParcelas);
            this.grp_InfosAdicionais.Controls.Add(this.cmb_QtdParcelas);
            this.grp_InfosAdicionais.Controls.Add(this.lbl_ParcelaAtual);
            this.grp_InfosAdicionais.Controls.Add(this.cmb_ParcelaAtual);
            this.grp_InfosAdicionais.Location = new System.Drawing.Point(12, 314);
            this.grp_InfosAdicionais.Name = "grp_InfosAdicionais";
            this.grp_InfosAdicionais.Size = new System.Drawing.Size(425, 71);
            this.grp_InfosAdicionais.TabIndex = 15;
            this.grp_InfosAdicionais.TabStop = false;
            // 
            // lbl_Cartao
            // 
            this.lbl_Cartao.AutoSize = true;
            this.lbl_Cartao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cartao.Location = new System.Drawing.Point(182, 19);
            this.lbl_Cartao.Name = "lbl_Cartao";
            this.lbl_Cartao.Size = new System.Drawing.Size(41, 15);
            this.lbl_Cartao.TabIndex = 27;
            this.lbl_Cartao.Text = "Cartão";
            // 
            // cmb_Cartao
            // 
            this.cmb_Cartao.FormattingEnabled = true;
            this.cmb_Cartao.Location = new System.Drawing.Point(179, 36);
            this.cmb_Cartao.Name = "cmb_Cartao";
            this.cmb_Cartao.Size = new System.Drawing.Size(232, 23);
            this.cmb_Cartao.TabIndex = 26;
            this.cmb_Cartao.Text = "NU Bank";
            // 
            // lbl_QtdParcelas
            // 
            this.lbl_QtdParcelas.AutoSize = true;
            this.lbl_QtdParcelas.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_QtdParcelas.Location = new System.Drawing.Point(93, 19);
            this.lbl_QtdParcelas.Name = "lbl_QtdParcelas";
            this.lbl_QtdParcelas.Size = new System.Drawing.Size(79, 15);
            this.lbl_QtdParcelas.TabIndex = 25;
            this.lbl_QtdParcelas.Text = "Qtde Parcelas";
            // 
            // cmb_QtdParcelas
            // 
            this.cmb_QtdParcelas.FormattingEnabled = true;
            this.cmb_QtdParcelas.Location = new System.Drawing.Point(90, 36);
            this.cmb_QtdParcelas.Name = "cmb_QtdParcelas";
            this.cmb_QtdParcelas.Size = new System.Drawing.Size(86, 23);
            this.cmb_QtdParcelas.TabIndex = 24;
            this.cmb_QtdParcelas.Text = "10";
            // 
            // lbl_ParcelaAtual
            // 
            this.lbl_ParcelaAtual.AutoSize = true;
            this.lbl_ParcelaAtual.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ParcelaAtual.Location = new System.Drawing.Point(9, 19);
            this.lbl_ParcelaAtual.Name = "lbl_ParcelaAtual";
            this.lbl_ParcelaAtual.Size = new System.Drawing.Size(76, 15);
            this.lbl_ParcelaAtual.TabIndex = 23;
            this.lbl_ParcelaAtual.Text = "Parcela Atual";
            // 
            // cmb_ParcelaAtual
            // 
            this.cmb_ParcelaAtual.FormattingEnabled = true;
            this.cmb_ParcelaAtual.Location = new System.Drawing.Point(6, 36);
            this.cmb_ParcelaAtual.Name = "cmb_ParcelaAtual";
            this.cmb_ParcelaAtual.Size = new System.Drawing.Size(81, 23);
            this.cmb_ParcelaAtual.TabIndex = 22;
            this.cmb_ParcelaAtual.Text = "1";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(249, 17);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(87, 23);
            this.btn_Salvar.TabIndex = 16;
            this.btn_Salvar.Text = "F1 - Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(249, 45);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(87, 23);
            this.btn_Sair.TabIndex = 17;
            this.btn_Sair.Text = "F4 - Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(341, 45);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(87, 23);
            this.btn_Excluir.TabIndex = 19;
            this.btn_Excluir.Text = "F3 - Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // btn_Novo
            // 
            this.btn_Novo.Location = new System.Drawing.Point(341, 17);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(87, 23);
            this.btn_Novo.TabIndex = 18;
            this.btn_Novo.Text = "F2 - Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            // 
            // Frm_CadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(449, 397);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.grp_InfosAdicionais);
            this.Controls.Add(this.grp_InfosPrincipais);
            this.Controls.Add(this.grp_InfosAutomaticas);
            this.Name = "Frm_CadastroConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Conta";
            this.grp_InfosAutomaticas.ResumeLayout(false);
            this.grp_InfosAutomaticas.PerformLayout();
            this.grp_InfosPrincipais.ResumeLayout(false);
            this.grp_InfosPrincipais.PerformLayout();
            this.grp_InfosAdicionais.ResumeLayout(false);
            this.grp_InfosAdicionais.PerformLayout();
            this.ResumeLayout(false);

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