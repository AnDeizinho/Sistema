namespace CaixaSimples
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMensalidade = new System.Windows.Forms.ToolStripButton();
            this.lblDinheiro = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.lblDebito = new System.Windows.Forms.Label();
            this.lblTotalEntradas = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.lblTotalSpecie = new System.Windows.Forms.Label();
            this.lblTotalCartao = new System.Windows.Forms.Label();
            this.lblTotalDeposito = new System.Windows.Forms.Label();
            this.lblValorApresentado = new System.Windows.Forms.Label();
            this.lblConclusao = new System.Windows.Forms.Label();
            this.lblFundoDeCaixa = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblStatu = new System.Windows.Forms.Label();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Elemento = new System.Windows.Forms.Integration.ElementHost();
            this.tbn_Cd_Cliente = new System.Windows.Forms.ToolStripButton();
            this.btn_Cd_Aluno = new System.Windows.Forms.ToolStripButton();
            this.btn_Pesquisar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnRelatorio = new System.Windows.Forms.ToolStripButton();
            this.btnDeposito = new System.Windows.Forms.ToolStripButton();
            this.btnProdutos = new System.Windows.Forms.ToolStripButton();
            this.btnSaida = new System.Windows.Forms.ToolStripButton();
            this.btnHistorico = new System.Windows.Forms.ToolStripButton();
            this.btnAbriCaixa = new System.Windows.Forms.ToolStripButton();
            this.btnFechaCaixa = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStrip1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMensalidade,
            this.btnRelatorio,
            this.btnDeposito,
            this.btnProdutos,
            this.btnSaida,
            this.btnHistorico,
            this.btnAbriCaixa,
            this.btnFechaCaixa});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1099, 30);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMensalidade
            // 
            this.btnMensalidade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMensalidade.Enabled = false;
            this.btnMensalidade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMensalidade.Name = "btnMensalidade";
            this.btnMensalidade.Size = new System.Drawing.Size(136, 27);
            this.btnMensalidade.Text = "&Mensalidade";
            this.btnMensalidade.Click += new System.EventHandler(this.btnMensalidade_Click);
            // 
            // lblDinheiro
            // 
            this.lblDinheiro.AutoSize = true;
            this.lblDinheiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDinheiro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiro.ForeColor = System.Drawing.Color.Olive;
            this.lblDinheiro.Location = new System.Drawing.Point(28, 40);
            this.lblDinheiro.Name = "lblDinheiro";
            this.lblDinheiro.Size = new System.Drawing.Size(127, 22);
            this.lblDinheiro.TabIndex = 13;
            this.lblDinheiro.Text = "Dinheiro : R$ ";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblCredito.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCredito.Location = new System.Drawing.Point(28, 136);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(121, 22);
            this.lblCredito.TabIndex = 14;
            this.lblCredito.Text = "Crédito : R$ ";
            // 
            // lblDebito
            // 
            this.lblDebito.AutoSize = true;
            this.lblDebito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDebito.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebito.ForeColor = System.Drawing.Color.Green;
            this.lblDebito.Location = new System.Drawing.Point(28, 104);
            this.lblDebito.Name = "lblDebito";
            this.lblDebito.Size = new System.Drawing.Size(114, 22);
            this.lblDebito.TabIndex = 15;
            this.lblDebito.Text = "Débito : R$ ";
            // 
            // lblTotalEntradas
            // 
            this.lblTotalEntradas.AutoSize = true;
            this.lblTotalEntradas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTotalEntradas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntradas.Location = new System.Drawing.Point(28, 200);
            this.lblTotalEntradas.Name = "lblTotalEntradas";
            this.lblTotalEntradas.Size = new System.Drawing.Size(177, 22);
            this.lblTotalEntradas.TabIndex = 16;
            this.lblTotalEntradas.Text = "Total Entradas: R$ ";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblSaida.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.ForeColor = System.Drawing.Color.Maroon;
            this.lblSaida.Location = new System.Drawing.Point(28, 72);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(106, 22);
            this.lblSaida.TabIndex = 17;
            this.lblSaida.Text = "Saídas: R$ ";
            // 
            // lblTotalSpecie
            // 
            this.lblTotalSpecie.AutoSize = true;
            this.lblTotalSpecie.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSpecie.Location = new System.Drawing.Point(28, 261);
            this.lblTotalSpecie.Name = "lblTotalSpecie";
            this.lblTotalSpecie.Size = new System.Drawing.Size(173, 23);
            this.lblTotalSpecie.TabIndex = 18;
            this.lblTotalSpecie.Text = "Total Espécie : R$ ";
            // 
            // lblTotalCartao
            // 
            this.lblTotalCartao.AutoSize = true;
            this.lblTotalCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTotalCartao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCartao.Location = new System.Drawing.Point(28, 168);
            this.lblTotalCartao.Name = "lblTotalCartao";
            this.lblTotalCartao.Size = new System.Drawing.Size(156, 22);
            this.lblTotalCartao.TabIndex = 19;
            this.lblTotalCartao.Text = "Total Catão: R$ ";
            // 
            // lblTotalDeposito
            // 
            this.lblTotalDeposito.AutoSize = true;
            this.lblTotalDeposito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTotalDeposito.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeposito.ForeColor = System.Drawing.Color.Purple;
            this.lblTotalDeposito.Location = new System.Drawing.Point(28, 334);
            this.lblTotalDeposito.Name = "lblTotalDeposito";
            this.lblTotalDeposito.Size = new System.Drawing.Size(212, 23);
            this.lblTotalDeposito.TabIndex = 20;
            this.lblTotalDeposito.Text = "Total de Depósito : R$ ";
            // 
            // lblValorApresentado
            // 
            this.lblValorApresentado.AutoSize = true;
            this.lblValorApresentado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblValorApresentado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorApresentado.ForeColor = System.Drawing.Color.Purple;
            this.lblValorApresentado.Location = new System.Drawing.Point(28, 367);
            this.lblValorApresentado.Name = "lblValorApresentado";
            this.lblValorApresentado.Size = new System.Drawing.Size(226, 23);
            this.lblValorApresentado.TabIndex = 21;
            this.lblValorApresentado.Text = "Valor Apresentado : R$ ";
            // 
            // lblConclusao
            // 
            this.lblConclusao.AutoSize = true;
            this.lblConclusao.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConclusao.ForeColor = System.Drawing.Color.Green;
            this.lblConclusao.Location = new System.Drawing.Point(28, 400);
            this.lblConclusao.Name = "lblConclusao";
            this.lblConclusao.Size = new System.Drawing.Size(79, 23);
            this.lblConclusao.TabIndex = 22;
            this.lblConclusao.Text = "Ok : R$ ";
            // 
            // lblFundoDeCaixa
            // 
            this.lblFundoDeCaixa.AutoSize = true;
            this.lblFundoDeCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFundoDeCaixa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFundoDeCaixa.ForeColor = System.Drawing.Color.Purple;
            this.lblFundoDeCaixa.Location = new System.Drawing.Point(28, 301);
            this.lblFundoDeCaixa.Name = "lblFundoDeCaixa";
            this.lblFundoDeCaixa.Size = new System.Drawing.Size(200, 23);
            this.lblFundoDeCaixa.TabIndex = 24;
            this.lblFundoDeCaixa.Text = "Fundo de Caixa : R$ ";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(564, 40);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(162, 23);
            this.lblData.TabIndex = 25;
            this.lblData.Text = "Data Do Caixa : ";
            // 
            // lblStatu
            // 
            this.lblStatu.AutoSize = true;
            this.lblStatu.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatu.Location = new System.Drawing.Point(274, 40);
            this.lblStatu.Name = "lblStatu";
            this.lblStatu.Size = new System.Drawing.Size(64, 23);
            this.lblStatu.TabIndex = 26;
            this.lblStatu.Text = "Status";
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblProdutos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.Location = new System.Drawing.Point(28, 232);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(176, 22);
            this.lblProdutos.TabIndex = 27;
            this.lblProdutos.Text = "Total Produtos: R$ ";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbn_Cd_Cliente,
            this.btn_Cd_Aluno,
            this.btn_Pesquisar,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 498);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1099, 25);
            this.toolStrip2.TabIndex = 28;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Elemento
            // 
            this.Elemento.Location = new System.Drawing.Point(355, 72);
            this.Elemento.Name = "Elemento";
            this.Elemento.Size = new System.Drawing.Size(732, 413);
            this.Elemento.TabIndex = 29;
            this.Elemento.Text = "elementHost1";
            this.Elemento.Child = null;
            // 
            // tbn_Cd_Cliente
            // 
            this.tbn_Cd_Cliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbn_Cd_Cliente.Image = ((System.Drawing.Image)(resources.GetObject("tbn_Cd_Cliente.Image")));
            this.tbn_Cd_Cliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbn_Cd_Cliente.Name = "tbn_Cd_Cliente";
            this.tbn_Cd_Cliente.Size = new System.Drawing.Size(101, 22);
            this.tbn_Cd_Cliente.Text = "Cadastrar Cliente";
            this.tbn_Cd_Cliente.Click += new System.EventHandler(this.tbn_Cd_Cliente_Click);
            // 
            // btn_Cd_Aluno
            // 
            this.btn_Cd_Aluno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Cd_Aluno.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cd_Aluno.Image")));
            this.btn_Cd_Aluno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Cd_Aluno.Name = "btn_Cd_Aluno";
            this.btn_Cd_Aluno.Size = new System.Drawing.Size(96, 22);
            this.btn_Cd_Aluno.Text = "Cadastrar Aluno";
            this.btn_Cd_Aluno.Click += new System.EventHandler(this.btn_Cd_Aluno_Click);
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pesquisar.Image")));
            this.btn_Pesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(61, 22);
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(126, 22);
            this.toolStripButton1.Text = "Lista de Mensalidades";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(50, 22);
            this.toolStripButton2.Text = "Boletos";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton3.Text = "gerenciar turmas";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRelatorio.Enabled = false;
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(162, 27);
            this.btnRelatorio.Text = "&Relatório do dia";
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDeposito.Enabled = false;
            this.btnDeposito.Image = ((System.Drawing.Image)(resources.GetObject("btnDeposito.Image")));
            this.btnDeposito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(95, 27);
            this.btnDeposito.Text = "&Depósito";
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnProdutos.Enabled = false;
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(93, 27);
            this.btnProdutos.Text = "&Produtos";
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnSaida
            // 
            this.btnSaida.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSaida.Enabled = false;
            this.btnSaida.Image = ((System.Drawing.Image)(resources.GetObject("btnSaida.Image")));
            this.btnSaida.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(68, 27);
            this.btnSaida.Text = "&Saída";
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHistorico.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorico.Image")));
            this.btnHistorico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(101, 27);
            this.btnHistorico.Text = "&Históricos";
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // btnAbriCaixa
            // 
            this.btnAbriCaixa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAbriCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btnAbriCaixa.Image")));
            this.btnAbriCaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbriCaixa.Name = "btnAbriCaixa";
            this.btnAbriCaixa.Size = new System.Drawing.Size(120, 27);
            this.btnAbriCaixa.Text = "&Abrir Caixa";
            this.btnAbriCaixa.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // btnFechaCaixa
            // 
            this.btnFechaCaixa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFechaCaixa.Enabled = false;
            this.btnFechaCaixa.Image = ((System.Drawing.Image)(resources.GetObject("btnFechaCaixa.Image")));
            this.btnFechaCaixa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechaCaixa.Name = "btnFechaCaixa";
            this.btnFechaCaixa.Size = new System.Drawing.Size(139, 27);
            this.btnFechaCaixa.Text = "&Fechar Caixa";
            this.btnFechaCaixa.Click += new System.EventHandler(this.btnFechaCaixa_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1099, 523);
            this.Controls.Add(this.Elemento);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.lblStatu);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblFundoDeCaixa);
            this.Controls.Add(this.lblConclusao);
            this.Controls.Add(this.lblValorApresentado);
            this.Controls.Add(this.lblTotalDeposito);
            this.Controls.Add(this.lblTotalCartao);
            this.Controls.Add(this.lblTotalSpecie);
            this.Controls.Add(this.lblSaida);
            this.Controls.Add(this.lblTotalEntradas);
            this.Controls.Add(this.lblDebito);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.lblDinheiro);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMensalidade;
        private System.Windows.Forms.ToolStripButton btnRelatorio;
        private System.Windows.Forms.ToolStripButton btnDeposito;
        private System.Windows.Forms.ToolStripButton btnProdutos;
        private System.Windows.Forms.ToolStripButton btnSaida;
        private System.Windows.Forms.ToolStripButton btnHistorico;
        private System.Windows.Forms.ToolStripButton btnAbriCaixa;
        private System.Windows.Forms.ToolStripButton btnFechaCaixa;
        private System.Windows.Forms.Label lblDinheiro;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Label lblDebito;
        private System.Windows.Forms.Label lblTotalEntradas;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Label lblTotalSpecie;
        private System.Windows.Forms.Label lblTotalCartao;
        private System.Windows.Forms.Label lblTotalDeposito;
        private System.Windows.Forms.Label lblValorApresentado;
        private System.Windows.Forms.Label lblConclusao;
        private System.Windows.Forms.Label lblFundoDeCaixa;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblStatu;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tbn_Cd_Cliente;
        private System.Windows.Forms.ToolStripButton btn_Cd_Aluno;
        private System.Windows.Forms.ToolStripButton btn_Pesquisar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Integration.ElementHost Elemento;
        private System.Windows.Forms.ToolStripButton toolStripButton3;


    }
}