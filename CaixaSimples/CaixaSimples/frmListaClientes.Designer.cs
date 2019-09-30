namespace CaixaSimples
{
    partial class frmListaClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dt = new System.Windows.Forms.DataGridView();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.cb = new System.Windows.Forms.ComboBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCod = new System.Windows.Forms.ComboBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.cbResp = new System.Windows.Forms.ComboBox();
            this.txtCodAltera = new System.Windows.Forms.TextBox();
            this.txtCBAltera = new System.Windows.Forms.TextBox();
            this.txtNomePai = new System.Windows.Forms.TextBox();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.txtFonePai = new System.Windows.Forms.MaskedTextBox();
            this.txtFoneMae = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnomePai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnomeMae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFonePai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFoneMae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AllowUserToDeleteRows = false;
            this.dt.AllowUserToOrderColumns = true;
            this.dt.AllowUserToResizeRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            this.dt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.clmCB,
            this.clmnomePai,
            this.clmnomeMae,
            this.Column4,
            this.Column5,
            this.clmFonePai,
            this.clmFoneMae,
            this.Column8,
            this.Column9,
            this.Column11,
            this.Column12,
            this.Column2,
            this.Column10,
            this.Column13,
            this.data,
            this.Column15,
            this.Column16,
            this.clmValor});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt.DefaultCellStyle = dataGridViewCellStyle21;
            this.dt.GridColor = System.Drawing.Color.White;
            this.dt.Location = new System.Drawing.Point(12, 114);
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.RowHeadersVisible = false;
            this.dt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt.Size = new System.Drawing.Size(1071, 356);
            this.dt.TabIndex = 0;
            this.dt.TabStop = false;
            this.dt.DataSourceChanged += new System.EventHandler(this.dt_DataSourceChanged);
            this.dt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_CellDoubleClick);
            // 
            // txtnome
            // 
            this.txtnome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.ForeColor = System.Drawing.Color.White;
            this.txtnome.Location = new System.Drawing.Point(497, 80);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(262, 26);
            this.txtnome.TabIndex = 3;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            this.txtnome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_Validating);
            this.txtnome.Validating += new System.ComponentModel.CancelEventHandler(this.txtnome_Validating);
            // 
            // cb
            // 
            this.cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.ForeColor = System.Drawing.Color.White;
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "Mensalidade",
            "janeiro",
            "fevereiro",
            "março",
            "abril",
            "maio",
            "junho",
            "julho",
            "agosto",
            "setembro",
            "outubro",
            "novembro",
            "dezembro"});
            this.cb.Location = new System.Drawing.Point(12, 79);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(186, 28);
            this.cb.TabIndex = 0;
            this.cb.SelectedValueChanged += new System.EventHandler(this.cb_SelectedValueChanged);
            this.cb.Validated += new System.EventHandler(this.cb_Validated);
            // 
            // txtano
            // 
            this.txtano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtano.ForeColor = System.Drawing.Color.White;
            this.txtano.Location = new System.Drawing.Point(204, 80);
            this.txtano.MaxLength = 4;
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(58, 26);
            this.txtano.TabIndex = 1;
            this.txtano.Text = "2019";
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(765, 80);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(104, 20);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Quantidade : ";
            // 
            // txtCC
            // 
            this.txtCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCC.ForeColor = System.Drawing.Color.White;
            this.txtCC.Location = new System.Drawing.Point(269, 80);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(86, 26);
            this.txtCC.TabIndex = 1;
            this.txtCC.TextChanged += new System.EventHandler(this.txtCC_TextChanged);
            this.txtCC.Validated += new System.EventHandler(this.txtCC_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Entrada Avulsa por :";
            // 
            // cbCod
            // 
            this.cbCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbCod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCod.ForeColor = System.Drawing.Color.White;
            this.cbCod.FormattingEnabled = true;
            this.cbCod.Items.AddRange(new object[] {
            "CC",
            "CB"});
            this.cbCod.Location = new System.Drawing.Point(164, 43);
            this.cbCod.Name = "cbCod";
            this.cbCod.Size = new System.Drawing.Size(89, 28);
            this.cbCod.TabIndex = 4;
            this.cbCod.Validated += new System.EventHandler(this.cbCod_Validated);
            // 
            // dtData
            // 
            this.dtData.CalendarForeColor = System.Drawing.Color.Black;
            this.dtData.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(462, 44);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(137, 26);
            this.dtData.TabIndex = 6;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(665, 44);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(106, 26);
            this.txtValor.TabIndex = 7;
            this.txtValor.Text = "0,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtValor_PreviewKeyDown);
            this.txtValor.Validated += new System.EventHandler(this.txtValor_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(406, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(605, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Valor :";
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.ForeColor = System.Drawing.Color.White;
            this.txtCod.Location = new System.Drawing.Point(331, 43);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(68, 26);
            this.txtCod.TabIndex = 5;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            this.txtCod.Validated += new System.EventHandler(this.txtCod_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(263, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Codigo :";
            // 
            // btnEntrada
            // 
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.Color.White;
            this.btnEntrada.Location = new System.Drawing.Point(780, 44);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(150, 26);
            this.btnEntrada.TabIndex = 8;
            this.btnEntrada.Text = "Entrada Avulsa";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // cbResp
            // 
            this.cbResp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbResp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResp.ForeColor = System.Drawing.Color.White;
            this.cbResp.FormattingEnabled = true;
            this.cbResp.Items.AddRange(new object[] {
            "Pai",
            "Mãe"});
            this.cbResp.Location = new System.Drawing.Point(361, 80);
            this.cbResp.Name = "cbResp";
            this.cbResp.Size = new System.Drawing.Size(130, 28);
            this.cbResp.TabIndex = 2;
            // 
            // txtCodAltera
            // 
            this.txtCodAltera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCodAltera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAltera.ForeColor = System.Drawing.Color.White;
            this.txtCodAltera.Location = new System.Drawing.Point(12, 9);
            this.txtCodAltera.Name = "txtCodAltera";
            this.txtCodAltera.Size = new System.Drawing.Size(86, 26);
            this.txtCodAltera.TabIndex = 9;
            this.txtCodAltera.Validated += new System.EventHandler(this.txtCodAltera_Validated);
            // 
            // txtCBAltera
            // 
            this.txtCBAltera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCBAltera.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCBAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCBAltera.ForeColor = System.Drawing.Color.White;
            this.txtCBAltera.Location = new System.Drawing.Point(106, 9);
            this.txtCBAltera.Name = "txtCBAltera";
            this.txtCBAltera.Size = new System.Drawing.Size(86, 26);
            this.txtCBAltera.TabIndex = 10;
            // 
            // txtNomePai
            // 
            this.txtNomePai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtNomePai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomePai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePai.ForeColor = System.Drawing.Color.White;
            this.txtNomePai.Location = new System.Drawing.Point(200, 9);
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Size = new System.Drawing.Size(202, 26);
            this.txtNomePai.TabIndex = 11;
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtNomeMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMae.ForeColor = System.Drawing.Color.White;
            this.txtNomeMae.Location = new System.Drawing.Point(410, 9);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(202, 26);
            this.txtNomeMae.TabIndex = 12;
            // 
            // txtFonePai
            // 
            this.txtFonePai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtFonePai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFonePai.ForeColor = System.Drawing.Color.White;
            this.txtFonePai.Location = new System.Drawing.Point(620, 9);
            this.txtFonePai.Mask = "(00) 00000-0000";
            this.txtFonePai.Name = "txtFonePai";
            this.txtFonePai.Size = new System.Drawing.Size(163, 26);
            this.txtFonePai.TabIndex = 13;
            // 
            // txtFoneMae
            // 
            this.txtFoneMae.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtFoneMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoneMae.ForeColor = System.Drawing.Color.White;
            this.txtFoneMae.Location = new System.Drawing.Point(791, 9);
            this.txtFoneMae.Mask = "(00) 00000-0000";
            this.txtFoneMae.Name = "txtFoneMae";
            this.txtFoneMae.Size = new System.Drawing.Size(163, 26);
            this.txtFoneMae.TabIndex = 14;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Location = new System.Drawing.Point(962, 9);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(118, 26);
            this.btnAtualizar.TabIndex = 15;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_Cliente";
            this.Column1.HeaderText = "CC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // clmCB
            // 
            this.clmCB.DataPropertyName = "CB";
            this.clmCB.HeaderText = "CB";
            this.clmCB.Name = "clmCB";
            this.clmCB.ReadOnly = true;
            // 
            // clmnomePai
            // 
            this.clmnomePai.DataPropertyName = "Pai";
            this.clmnomePai.HeaderText = "Pai";
            this.clmnomePai.MaxInputLength = 100;
            this.clmnomePai.Name = "clmnomePai";
            this.clmnomePai.ReadOnly = true;
            // 
            // clmnomeMae
            // 
            this.clmnomeMae.DataPropertyName = "mae";
            this.clmnomeMae.HeaderText = "Mãe";
            this.clmnomeMae.MaxInputLength = 100;
            this.clmnomeMae.Name = "clmnomeMae";
            this.clmnomeMae.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "cpf_pai";
            this.Column4.HeaderText = "CPF do Pai";
            this.Column4.MaxInputLength = 20;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "cpf_mae";
            this.Column5.HeaderText = "CPF da Mãe";
            this.Column5.MaxInputLength = 20;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // clmFonePai
            // 
            this.clmFonePai.DataPropertyName = "fone_pai";
            this.clmFonePai.HeaderText = "N° do Pai";
            this.clmFonePai.MaxInputLength = 20;
            this.clmFonePai.Name = "clmFonePai";
            this.clmFonePai.ReadOnly = true;
            // 
            // clmFoneMae
            // 
            this.clmFoneMae.DataPropertyName = "fone_mae";
            this.clmFoneMae.HeaderText = "N° da Mãe";
            this.clmFoneMae.MaxInputLength = 20;
            this.clmFoneMae.Name = "clmFoneMae";
            this.clmFoneMae.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "endereco";
            this.Column8.HeaderText = "Endereço";
            this.Column8.MaxInputLength = 150;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "numero";
            this.Column9.HeaderText = "N°";
            this.Column9.MaxInputLength = 20;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "bairro";
            this.Column11.HeaderText = "Bairro";
            this.Column11.MaxInputLength = 150;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "complemento";
            this.Column12.HeaderText = "Complemento";
            this.Column12.MaxInputLength = 150;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cidade";
            this.Column2.HeaderText = "Cidade";
            this.Column2.MaxInputLength = 50;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "estado";
            this.Column10.HeaderText = "UF";
            this.Column10.MaxInputLength = 3;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "cep";
            this.Column13.HeaderText = "CEP";
            this.Column13.MaxInputLength = 10;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data Pagamento";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "meses";
            this.Column15.HeaderText = "Mensalidade";
            this.Column15.MaxInputLength = 50;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "filhos";
            this.Column16.HeaderText = "Filhos";
            this.Column16.MaxInputLength = 2;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // clmValor
            // 
            this.clmValor.DataPropertyName = "valor";
            this.clmValor.HeaderText = "Valor";
            this.clmValor.Name = "clmValor";
            this.clmValor.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(933, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 26);
            this.button1.TabIndex = 16;
            this.button1.Text = "Devedores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1095, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtFoneMae);
            this.Controls.Add(this.txtFonePai);
            this.Controls.Add(this.txtNomeMae);
            this.Controls.Add(this.txtNomePai);
            this.Controls.Add(this.txtCBAltera);
            this.Controls.Add(this.txtCodAltera);
            this.Controls.Add(this.cbResp);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.cbCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.dt);
            this.Name = "frmListaClientes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCod;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.ComboBox cbResp;
        private System.Windows.Forms.TextBox txtCodAltera;
        private System.Windows.Forms.TextBox txtCBAltera;
        private System.Windows.Forms.TextBox txtNomePai;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.MaskedTextBox txtFonePai;
        private System.Windows.Forms.MaskedTextBox txtFoneMae;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnomePai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnomeMae;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFonePai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFoneMae;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValor;
        private System.Windows.Forms.Button button1;
    }
}