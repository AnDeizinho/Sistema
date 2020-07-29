namespace CaixaSimples
{
    partial class FormMensalidade
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMensalidade));
            this.cbSerie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAluno = new System.Windows.Forms.Label();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPagamento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.imprimi = new System.Drawing.Printing.PrintDocument();
            this.dialogo = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.cbano = new System.Windows.Forms.ComboBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilhos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.dataGridView1 = new CaixaSimples.DataGridBase();
            this.meses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DTGV = new CaixaSimples.DataGridBase();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Forma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDaMensalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSerie
            // 
            this.cbSerie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSerie.ForeColor = System.Drawing.Color.Navy;
            this.cbSerie.FormattingEnabled = true;
            this.cbSerie.Items.AddRange(new object[] {
            "selecione"});
            this.cbSerie.Location = new System.Drawing.Point(393, 9);
            this.cbSerie.Name = "cbSerie";
            this.cbSerie.Size = new System.Drawing.Size(220, 30);
            this.cbSerie.TabIndex = 1;
            this.cbSerie.Validated += new System.EventHandler(this.cbSerie_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Série :";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(16, 56);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(81, 22);
            this.lblAluno.TabIndex = 2;
            this.lblAluno.Text = "Alunos :";
            // 
            // txtAluno
            // 
            this.txtAluno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAluno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAluno.ForeColor = System.Drawing.Color.Navy;
            this.txtAluno.Location = new System.Drawing.Point(100, 56);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(513, 24);
            this.txtAluno.TabIndex = 2;
            this.txtAluno.Validated += new System.EventHandler(this.txtAluno_Validated);
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMes.ForeColor = System.Drawing.Color.Navy;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "JANEIRO",
            "FEVEREIRO",
            "MARÇO",
            "ABRIL",
            "MAIO",
            "JUNHO",
            "JULHO",
            "AGOSTO",
            "SETEMBRO",
            "OUTUBRO",
            "NOVEMBRO",
            "DEZEMBRO"});
            this.cbMes.Location = new System.Drawing.Point(81, 177);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(265, 30);
            this.cbMes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mês :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pagamento :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbPagamento
            // 
            this.cbPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPagamento.ForeColor = System.Drawing.Color.Navy;
            this.cbPagamento.FormattingEnabled = true;
            this.cbPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Crédito"});
            this.cbPagamento.Location = new System.Drawing.Point(149, 223);
            this.cbPagamento.Name = "cbPagamento";
            this.cbPagamento.Size = new System.Drawing.Size(197, 30);
            this.cbPagamento.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor :";
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValor.ForeColor = System.Drawing.Color.Navy;
            this.txtValor.Location = new System.Drawing.Point(81, 264);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(265, 24);
            this.txtValor.TabIndex = 5;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.Validating += new System.ComponentModel.CancelEventHandler(this.txtValor_Validating);
            // 
            // btnConcluir
            // 
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.Location = new System.Drawing.Point(20, 305);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(154, 39);
            this.btnConcluir.TabIndex = 6;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // imprimi
            // 
            this.imprimi.DocumentName = "documento";
            this.imprimi.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.imprimi_PrintPage);
            // 
            // dialogo
            // 
            this.dialogo.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dialogo.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dialogo.ClientSize = new System.Drawing.Size(400, 300);
            this.dialogo.Document = this.imprimi;
            this.dialogo.Enabled = true;
            this.dialogo.Icon = ((System.Drawing.Icon)(resources.GetObject("dialogo.Icon")));
            this.dialogo.Name = "dialogo";
            this.dialogo.Visible = false;
            this.dialogo.Load += new System.EventHandler(this.dialogo_Load);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // cbano
            // 
            this.cbano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbano.ForeColor = System.Drawing.Color.Navy;
            this.cbano.FormattingEnabled = true;
            this.cbano.Items.AddRange(new object[] {
            "ANO",
            "2020",
            "2019",
            "2018",
            "2017"});
            this.cbano.Location = new System.Drawing.Point(82, 6);
            this.cbano.Name = "cbano";
            this.cbano.Size = new System.Drawing.Size(202, 30);
            this.cbano.TabIndex = 0;
            this.cbano.Validated += new System.EventHandler(this.cbano_Validated);
            // 
            // txtCC
            // 
            this.txtCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCC.Enabled = false;
            this.txtCC.ForeColor = System.Drawing.Color.Navy;
            this.txtCC.Location = new System.Drawing.Point(72, 138);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(71, 24);
            this.txtCC.TabIndex = 12;
            this.txtCC.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "CC :";
            // 
            // txtFilhos
            // 
            this.txtFilhos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilhos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFilhos.Enabled = false;
            this.txtFilhos.ForeColor = System.Drawing.Color.Navy;
            this.txtFilhos.Location = new System.Drawing.Point(266, 138);
            this.txtFilhos.Name = "txtFilhos";
            this.txtFilhos.Size = new System.Drawing.Size(80, 24);
            this.txtFilhos.TabIndex = 14;
            this.txtFilhos.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "N° Filhos :";
            // 
            // lblAviso
            // 
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.Location = new System.Drawing.Point(17, 92);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(329, 33);
            this.lblAviso.TabIndex = 16;
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.meses,
            this.Valor});
            this.dataGridView1.GridColor = System.Drawing.Color.Navy;
            this.dataGridView1.Location = new System.Drawing.Point(366, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(247, 226);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 17;
            // 
            // meses
            // 
            this.meses.DataPropertyName = "meses";
            this.meses.HeaderText = "Mês";
            this.meses.Name = "meses";
            this.meses.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ano :";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(363, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "Meses";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTGV
            // 
            this.DTGV.AllowUserToAddRows = false;
            this.DTGV.AllowUserToDeleteRows = false;
            this.DTGV.AllowUserToResizeRows = false;
            this.DTGV.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.DTGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Data,
            this.Mes,
            this.Forma,
            this.valorDaMensalidade});
            this.DTGV.GridColor = System.Drawing.Color.Navy;
            this.DTGV.Location = new System.Drawing.Point(20, 366);
            this.DTGV.Name = "DTGV";
            this.DTGV.ReadOnly = true;
            this.DTGV.RowHeadersVisible = false;
            this.DTGV.Size = new System.Drawing.Size(593, 183);
            this.DTGV.StandardTab = true;
            this.DTGV.TabIndex = 21;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id_Cliente";
            this.id.HeaderText = "CC";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Mes
            // 
            this.Mes.DataPropertyName = "Mes";
            this.Mes.HeaderText = "Mês";
            this.Mes.Name = "Mes";
            this.Mes.ReadOnly = true;
            // 
            // Forma
            // 
            this.Forma.DataPropertyName = "Forma_Pagamento";
            this.Forma.HeaderText = "Pagamento";
            this.Forma.Name = "Forma";
            this.Forma.ReadOnly = true;
            // 
            // valorDaMensalidade
            // 
            this.valorDaMensalidade.DataPropertyName = "Valor";
            this.valorDaMensalidade.HeaderText = "Valor";
            this.valorDaMensalidade.Name = "valorDaMensalidade";
            this.valorDaMensalidade.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(192, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 39);
            this.button1.TabIndex = 22;
            this.button1.Text = "Recibo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormMensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DTGV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtFilhos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbano);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSerie);
            this.Name = "FormMensalidade";
            this.Load += new System.EventHandler(this.FormMensalidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPagamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnConcluir;
        private System.Drawing.Printing.PrintDocument imprimi;
        private System.Windows.Forms.PrintPreviewDialog dialogo;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.ComboBox cbano;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFilhos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAviso;
        private DataGridBase dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn meses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private DataGridBase DTGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forma;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDaMensalidade;
        private System.Windows.Forms.Button button1;
    }
}