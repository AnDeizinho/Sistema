namespace CaixaSimples
{
    partial class FrmBoletos
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
            this.tblMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSBoletosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSBoletos = new CaixaSimples.DSBoletos();
            this.tbl_MesTableAdapter = new CaixaSimples.DSBoletosTableAdapters.tbl_MesTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtHist = new System.Windows.Forms.DataGridView();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMensalidadeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDcaixaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDcaixaDataSet = new CaixaSimples.BDcaixaDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtMensalidade = new System.Windows.Forms.DataGridView();
            this.id_meses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filhosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_venc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataVencimento = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.tbnSalvar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnLancar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtmeses = new System.Windows.Forms.TextBox();
            this.txtminimo = new System.Windows.Forms.TextBox();
            this.txtboleto = new System.Windows.Forms.TextBox();
            this.txtmae = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtpai = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.CBCod = new System.Windows.Forms.ComboBox();
            this.tblMensalidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MensalidadeTableAdapter = new CaixaSimples.BDcaixaDataSetTableAdapters.tbl_MensalidadeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblMesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBoletosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBoletos)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMensalidadeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDcaixaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDcaixaDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtMensalidade)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMensalidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMesBindingSource
            // 
            this.tblMesBindingSource.DataMember = "tbl_Mes";
            this.tblMesBindingSource.DataSource = this.dSBoletosBindingSource;
            // 
            // dSBoletosBindingSource
            // 
            this.dSBoletosBindingSource.DataSource = this.dSBoletos;
            this.dSBoletosBindingSource.Position = 0;
            // 
            // dSBoletos
            // 
            this.dSBoletos.DataSetName = "DSBoletos";
            this.dSBoletos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_MesTableAdapter
            // 
            this.tbl_MesTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.dtHist);
            this.panel4.Location = new System.Drawing.Point(355, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(666, 235);
            this.panel4.TabIndex = 2;
            // 
            // dtHist
            // 
            this.dtHist.AllowUserToAddRows = false;
            this.dtHist.AllowUserToDeleteRows = false;
            this.dtHist.AutoGenerateColumns = false;
            this.dtHist.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dtHist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.alunoDataGridViewTextBoxColumn,
            this.mesDataGridViewTextBoxColumn,
            this.formaPagamentoDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dtHist.DataSource = this.tblMensalidadeBindingSource1;
            this.dtHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtHist.GridColor = System.Drawing.Color.SteelBlue;
            this.dtHist.Location = new System.Drawing.Point(0, 0);
            this.dtHist.Name = "dtHist";
            this.dtHist.ReadOnly = true;
            this.dtHist.RowHeadersVisible = false;
            this.dtHist.Size = new System.Drawing.Size(666, 235);
            this.dtHist.TabIndex = 0;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alunoDataGridViewTextBoxColumn
            // 
            this.alunoDataGridViewTextBoxColumn.DataPropertyName = "Aluno";
            this.alunoDataGridViewTextBoxColumn.HeaderText = "Aluno";
            this.alunoDataGridViewTextBoxColumn.Name = "alunoDataGridViewTextBoxColumn";
            this.alunoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mesDataGridViewTextBoxColumn
            // 
            this.mesDataGridViewTextBoxColumn.DataPropertyName = "Mes";
            this.mesDataGridViewTextBoxColumn.HeaderText = "Mes";
            this.mesDataGridViewTextBoxColumn.Name = "mesDataGridViewTextBoxColumn";
            this.mesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formaPagamentoDataGridViewTextBoxColumn
            // 
            this.formaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "Forma_Pagamento";
            this.formaPagamentoDataGridViewTextBoxColumn.HeaderText = "Forma_Pagamento";
            this.formaPagamentoDataGridViewTextBoxColumn.Name = "formaPagamentoDataGridViewTextBoxColumn";
            this.formaPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblMensalidadeBindingSource1
            // 
            this.tblMensalidadeBindingSource1.DataMember = "tbl_Mensalidade";
            this.tblMensalidadeBindingSource1.DataSource = this.bDcaixaDataSetBindingSource;
            // 
            // bDcaixaDataSetBindingSource
            // 
            this.bDcaixaDataSetBindingSource.DataSource = this.bDcaixaDataSet;
            this.bDcaixaDataSetBindingSource.Position = 0;
            // 
            // bDcaixaDataSet
            // 
            this.bDcaixaDataSet.DataSetName = "BDcaixaDataSet";
            this.bDcaixaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.dtMensalidade);
            this.panel3.Location = new System.Drawing.Point(355, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 299);
            this.panel3.TabIndex = 1;
            // 
            // dtMensalidade
            // 
            this.dtMensalidade.AllowUserToAddRows = false;
            this.dtMensalidade.AllowUserToDeleteRows = false;
            this.dtMensalidade.AllowUserToResizeRows = false;
            this.dtMensalidade.AutoGenerateColumns = false;
            this.dtMensalidade.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dtMensalidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtMensalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMensalidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_meses,
            this.idClienteDataGridViewTextBoxColumn,
            this.meses,
            this.aNODataGridViewTextBoxColumn,
            this.data,
            this.valor,
            this.cbDataGridViewTextBoxColumn,
            this.parcelaminDataGridViewTextBoxColumn,
            this.paiDataGridViewTextBoxColumn,
            this.maeDataGridViewTextBoxColumn,
            this.filhosDataGridViewTextBoxColumn,
            this.Data_venc});
            this.dtMensalidade.DataSource = this.tblMesBindingSource;
            this.dtMensalidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtMensalidade.GridColor = System.Drawing.Color.SteelBlue;
            this.dtMensalidade.Location = new System.Drawing.Point(0, 0);
            this.dtMensalidade.Name = "dtMensalidade";
            this.dtMensalidade.ReadOnly = true;
            this.dtMensalidade.RowHeadersVisible = false;
            this.dtMensalidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtMensalidade.Size = new System.Drawing.Size(666, 299);
            this.dtMensalidade.TabIndex = 0;
            this.dtMensalidade.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // id_meses
            // 
            this.id_meses.DataPropertyName = "id_meses";
            this.id_meses.HeaderText = "id_meses";
            this.id_meses.Name = "id_meses";
            this.id_meses.ReadOnly = true;
            this.id_meses.Visible = false;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "id_Cliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "CC";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // meses
            // 
            this.meses.DataPropertyName = "Meses";
            this.meses.HeaderText = "Meses";
            this.meses.Name = "meses";
            this.meses.ReadOnly = true;
            // 
            // aNODataGridViewTextBoxColumn
            // 
            this.aNODataGridViewTextBoxColumn.DataPropertyName = "ANO";
            this.aNODataGridViewTextBoxColumn.HeaderText = "ANO";
            this.aNODataGridViewTextBoxColumn.Name = "aNODataGridViewTextBoxColumn";
            this.aNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "Data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "Valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // cbDataGridViewTextBoxColumn
            // 
            this.cbDataGridViewTextBoxColumn.DataPropertyName = "cb";
            this.cbDataGridViewTextBoxColumn.HeaderText = "cb";
            this.cbDataGridViewTextBoxColumn.Name = "cbDataGridViewTextBoxColumn";
            this.cbDataGridViewTextBoxColumn.ReadOnly = true;
            this.cbDataGridViewTextBoxColumn.Visible = false;
            // 
            // parcelaminDataGridViewTextBoxColumn
            // 
            this.parcelaminDataGridViewTextBoxColumn.DataPropertyName = "parcela_min";
            this.parcelaminDataGridViewTextBoxColumn.HeaderText = "Parcela Mínima";
            this.parcelaminDataGridViewTextBoxColumn.Name = "parcelaminDataGridViewTextBoxColumn";
            this.parcelaminDataGridViewTextBoxColumn.ReadOnly = true;
            this.parcelaminDataGridViewTextBoxColumn.Visible = false;
            // 
            // paiDataGridViewTextBoxColumn
            // 
            this.paiDataGridViewTextBoxColumn.DataPropertyName = "Pai";
            this.paiDataGridViewTextBoxColumn.HeaderText = "Pai";
            this.paiDataGridViewTextBoxColumn.Name = "paiDataGridViewTextBoxColumn";
            this.paiDataGridViewTextBoxColumn.ReadOnly = true;
            this.paiDataGridViewTextBoxColumn.Visible = false;
            // 
            // maeDataGridViewTextBoxColumn
            // 
            this.maeDataGridViewTextBoxColumn.DataPropertyName = "mae";
            this.maeDataGridViewTextBoxColumn.HeaderText = "mae";
            this.maeDataGridViewTextBoxColumn.Name = "maeDataGridViewTextBoxColumn";
            this.maeDataGridViewTextBoxColumn.ReadOnly = true;
            this.maeDataGridViewTextBoxColumn.Visible = false;
            // 
            // filhosDataGridViewTextBoxColumn
            // 
            this.filhosDataGridViewTextBoxColumn.DataPropertyName = "filhos";
            this.filhosDataGridViewTextBoxColumn.HeaderText = "Filhos";
            this.filhosDataGridViewTextBoxColumn.Name = "filhosDataGridViewTextBoxColumn";
            this.filhosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Data_venc
            // 
            this.Data_venc.DataPropertyName = "Data_venc";
            this.Data_venc.HeaderText = "Vencimento";
            this.Data_venc.Name = "Data_venc";
            this.Data_venc.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.DataVencimento);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtTaxa);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.tbnSalvar);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.btnLancar);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.txtmeses);
            this.panel1.Controls.Add(this.txtminimo);
            this.panel1.Controls.Add(this.txtboleto);
            this.panel1.Controls.Add(this.txtmae);
            this.panel1.Controls.Add(this.txtCod);
            this.panel1.Controls.Add(this.txtpai);
            this.panel1.Controls.Add(this.txtAno);
            this.panel1.Controls.Add(this.CBCod);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 540);
            this.panel1.TabIndex = 0;
            // 
            // DataVencimento
            // 
            this.DataVencimento.CalendarForeColor = System.Drawing.Color.Navy;
            this.DataVencimento.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.DataVencimento.Enabled = false;
            this.DataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataVencimento.Location = new System.Drawing.Point(177, 321);
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.Size = new System.Drawing.Size(155, 31);
            this.DataVencimento.TabIndex = 30;
            this.DataVencimento.Validated += new System.EventHandler(this.DataVencimento_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(177, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 21);
            this.label12.TabIndex = 29;
            this.label12.Text = "Taxa Vencimento :";
            // 
            // txtTaxa
            // 
            this.txtTaxa.Enabled = false;
            this.txtTaxa.ForeColor = System.Drawing.Color.Navy;
            this.txtTaxa.Location = new System.Drawing.Point(177, 384);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(155, 31);
            this.txtTaxa.TabIndex = 10;
            this.txtTaxa.Validated += new System.EventHandler(this.txtTaxa_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(173, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 22);
            this.label11.TabIndex = 27;
            this.label11.Text = "Vencimento :";
            // 
            // date
            // 
            this.date.CalendarForeColor = System.Drawing.Color.Navy;
            this.date.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(12, 384);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(155, 31);
            this.date.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 22);
            this.label10.TabIndex = 25;
            this.label10.Text = "Data:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 22);
            this.label9.TabIndex = 24;
            this.label9.Text = "Valor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "Mensalidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Valor Mínimo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Boleto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mãe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pai:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ano:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Por:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(178, 434);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(154, 44);
            this.btnDeletar.TabIndex = 15;
            this.btnDeletar.Text = "Remover Mens.";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // tbnSalvar
            // 
            this.tbnSalvar.Enabled = false;
            this.tbnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnSalvar.Location = new System.Drawing.Point(232, 494);
            this.tbnSalvar.Name = "tbnSalvar";
            this.tbnSalvar.Size = new System.Drawing.Size(100, 34);
            this.tbnSalvar.TabIndex = 14;
            this.tbnSalvar.Text = "Salvar";
            this.tbnSalvar.UseVisualStyleBackColor = true;
            this.tbnSalvar.Click += new System.EventHandler(this.tbnSalvar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(122, 494);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 34);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLancar
            // 
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.Location = new System.Drawing.Point(12, 494);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(100, 34);
            this.btnLancar.TabIndex = 12;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = true;
            this.btnLancar.Click += new System.EventHandler(this.btnLancar_Click);
            // 
            // txtValor
            // 
            this.txtValor.ForeColor = System.Drawing.Color.Navy;
            this.txtValor.Location = new System.Drawing.Point(12, 447);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(155, 31);
            this.txtValor.TabIndex = 11;
            // 
            // txtmeses
            // 
            this.txtmeses.Enabled = false;
            this.txtmeses.ForeColor = System.Drawing.Color.Navy;
            this.txtmeses.Location = new System.Drawing.Point(12, 321);
            this.txtmeses.Name = "txtmeses";
            this.txtmeses.Size = new System.Drawing.Size(155, 31);
            this.txtmeses.TabIndex = 7;
            // 
            // txtminimo
            // 
            this.txtminimo.Enabled = false;
            this.txtminimo.ForeColor = System.Drawing.Color.Navy;
            this.txtminimo.Location = new System.Drawing.Point(177, 251);
            this.txtminimo.Name = "txtminimo";
            this.txtminimo.Size = new System.Drawing.Size(155, 31);
            this.txtminimo.TabIndex = 6;
            // 
            // txtboleto
            // 
            this.txtboleto.Enabled = false;
            this.txtboleto.ForeColor = System.Drawing.Color.Navy;
            this.txtboleto.Location = new System.Drawing.Point(12, 251);
            this.txtboleto.Name = "txtboleto";
            this.txtboleto.Size = new System.Drawing.Size(127, 31);
            this.txtboleto.TabIndex = 5;
            // 
            // txtmae
            // 
            this.txtmae.Enabled = false;
            this.txtmae.ForeColor = System.Drawing.Color.Navy;
            this.txtmae.Location = new System.Drawing.Point(12, 187);
            this.txtmae.Name = "txtmae";
            this.txtmae.Size = new System.Drawing.Size(320, 31);
            this.txtmae.TabIndex = 4;
            // 
            // txtCod
            // 
            this.txtCod.ForeColor = System.Drawing.Color.Navy;
            this.txtCod.Location = new System.Drawing.Point(86, 61);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 31);
            this.txtCod.TabIndex = 2;
            this.txtCod.Validated += new System.EventHandler(this.textBox3_Validated);
            // 
            // txtpai
            // 
            this.txtpai.Enabled = false;
            this.txtpai.ForeColor = System.Drawing.Color.Navy;
            this.txtpai.Location = new System.Drawing.Point(12, 126);
            this.txtpai.Name = "txtpai";
            this.txtpai.Size = new System.Drawing.Size(320, 31);
            this.txtpai.TabIndex = 3;
            // 
            // txtAno
            // 
            this.txtAno.ForeColor = System.Drawing.Color.Navy;
            this.txtAno.Location = new System.Drawing.Point(273, 14);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(65, 31);
            this.txtAno.TabIndex = 1;
            this.txtAno.Text = "2019";
            // 
            // CBCod
            // 
            this.CBCod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBCod.ForeColor = System.Drawing.Color.Navy;
            this.CBCod.FormattingEnabled = true;
            this.CBCod.Items.AddRange(new object[] {
            "CB",
            "CC"});
            this.CBCod.Location = new System.Drawing.Point(86, 15);
            this.CBCod.Name = "CBCod";
            this.CBCod.Size = new System.Drawing.Size(100, 30);
            this.CBCod.TabIndex = 0;
            // 
            // tblMensalidadeBindingSource
            // 
            this.tblMensalidadeBindingSource.DataMember = "tbl_Mensalidade";
            this.tblMensalidadeBindingSource.DataSource = this.bDcaixaDataSet;
            // 
            // tbl_MensalidadeTableAdapter
            // 
            this.tbl_MensalidadeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 540);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.Name = "FrmBoletos";
            this.ShowInTaskbar = true;
            this.Text = "Boletos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmBoletos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBoletosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBoletos)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMensalidadeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDcaixaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDcaixaDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtMensalidade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMensalidadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtMensalidade;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource dSBoletosBindingSource;
        private DSBoletos dSBoletos;
        private System.Windows.Forms.BindingSource tblMesBindingSource;
        private DSBoletosTableAdapters.tbl_MesTableAdapter tbl_MesTableAdapter;
        private System.Windows.Forms.DataGridView dtHist;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.ComboBox CBCod;
        private System.Windows.Forms.BindingSource tblMensalidadeBindingSource;
        private BDcaixaDataSet bDcaixaDataSet;
        private BDcaixaDataSetTableAdapters.tbl_MensalidadeTableAdapter tbl_MensalidadeTableAdapter;
        private System.Windows.Forms.Button tbnSalvar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtmeses;
        private System.Windows.Forms.TextBox txtminimo;
        private System.Windows.Forms.TextBox txtboleto;
        private System.Windows.Forms.TextBox txtmae;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtpai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblMensalidadeBindingSource1;
        private System.Windows.Forms.BindingSource bDcaixaDataSetBindingSource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_meses;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meses;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filhosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_venc;
        private System.Windows.Forms.DateTimePicker DataVencimento;
    }
}