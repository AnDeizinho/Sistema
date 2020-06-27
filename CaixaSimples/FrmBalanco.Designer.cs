namespace CaixaSimples
{
    partial class FrmBalanco
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
            this.tblResumoDeCaixasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSource = new CaixaSimples.DataSource();
            this.tblResumo_De_CaixasTableAdapter = new CaixaSimples.DataSourceTableAdapters.tblResumo_De_CaixasTableAdapter();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dt2 = new System.Windows.Forms.DateTimePicker();
            this.dt1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel10 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel12 = new System.Windows.Forms.ToolStripLabel();
            this.Grid = new CaixaSimples.DataGridBase();
            this.dataDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinheiroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCartaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalProdutosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalEspecieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundoDeCaixaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDepositoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorApresentadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conclusaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblResumoDeCaixasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // tblResumoDeCaixasBindingSource
            // 
            this.tblResumoDeCaixasBindingSource.DataMember = "tblResumo_De_Caixas";
            this.tblResumoDeCaixasBindingSource.DataSource = this.dataSource;
            // 
            // dataSource
            // 
            this.dataSource.DataSetName = "DataSource";
            this.dataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblResumo_De_CaixasTableAdapter
            // 
            this.tblResumo_De_CaixasTableAdapter.ClearBeforeFill = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Location = new System.Drawing.Point(663, 10);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(147, 31);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(517, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dt2
            // 
            this.dt2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt2.Location = new System.Drawing.Point(386, 10);
            this.dt2.Name = "dt2";
            this.dt2.Size = new System.Drawing.Size(128, 31);
            this.dt2.TabIndex = 3;
            // 
            // dt1
            // 
            this.dt1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt1.Location = new System.Drawing.Point(139, 10);
            this.dt1.Name = "dt1";
            this.dt1.Size = new System.Drawing.Size(127, 31);
            this.dt1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Data Inicial :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Data Final :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.toolStripLabel5,
            this.toolStripLabel6,
            this.toolStripLabel7,
            this.toolStripLabel8,
            this.toolStripLabel9,
            this.toolStripLabel10,
            this.toolStripLabel11,
            this.toolStripLabel12});
            this.toolStrip1.Location = new System.Drawing.Point(1009, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(18, 396);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(15, 25);
            this.toolStripLabel1.Text = " ";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(15, 25);
            this.toolStripLabel2.Text = " ";
            this.toolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(15, 25);
            this.toolStripLabel3.Text = " ";
            this.toolStripLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(15, 25);
            this.toolStripLabel4.Text = " ";
            this.toolStripLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(15, 25);
            this.toolStripLabel5.Text = " ";
            this.toolStripLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(15, 25);
            this.toolStripLabel6.Text = " ";
            this.toolStripLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(15, 25);
            this.toolStripLabel7.Text = " ";
            this.toolStripLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(15, 25);
            this.toolStripLabel8.Text = " ";
            this.toolStripLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(15, 25);
            this.toolStripLabel9.Text = " ";
            this.toolStripLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel10
            // 
            this.toolStripLabel10.Name = "toolStripLabel10";
            this.toolStripLabel10.Size = new System.Drawing.Size(15, 25);
            this.toolStripLabel10.Text = " ";
            this.toolStripLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(15, 25);
            this.toolStripLabel11.Text = " ";
            this.toolStripLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel12
            // 
            this.toolStripLabel12.Name = "toolStripLabel12";
            this.toolStripLabel12.Size = new System.Drawing.Size(15, 25);
            this.toolStripLabel12.Text = " ";
            this.toolStripLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Grid.AutoGenerateColumns = false;
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn,
            this.dinheiroDataGridViewTextBoxColumn,
            this.saidaDataGridViewTextBoxColumn,
            this.debitoDataGridViewTextBoxColumn,
            this.creditoDataGridViewTextBoxColumn,
            this.totalCartaoDataGridViewTextBoxColumn,
            this.totalEntradaDataGridViewTextBoxColumn,
            this.totalProdutosDataGridViewTextBoxColumn,
            this.totalEspecieDataGridViewTextBoxColumn,
            this.fundoDeCaixaDataGridViewTextBoxColumn,
            this.totalDepositoDataGridViewTextBoxColumn,
            this.valorApresentadoDataGridViewTextBoxColumn,
            this.conclusaoDataGridViewTextBoxColumn});
            this.Grid.DataSource = this.tblResumoDeCaixasBindingSource;
            this.Grid.Location = new System.Drawing.Point(16, 47);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersVisible = false;
            this.Grid.Size = new System.Drawing.Size(990, 323);
            this.Grid.TabIndex = 0;
            // 
            // dataDataGridViewTextBoxColumn1
            // 
            this.dataDataGridViewTextBoxColumn1.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn1.Name = "dataDataGridViewTextBoxColumn1";
            this.dataDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn1.Width = 82;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 90;
            // 
            // dinheiroDataGridViewTextBoxColumn
            // 
            this.dinheiroDataGridViewTextBoxColumn.DataPropertyName = "Dinheiro";
            this.dinheiroDataGridViewTextBoxColumn.HeaderText = "Dinheiro";
            this.dinheiroDataGridViewTextBoxColumn.Name = "dinheiroDataGridViewTextBoxColumn";
            this.dinheiroDataGridViewTextBoxColumn.ReadOnly = true;
            this.dinheiroDataGridViewTextBoxColumn.Width = 109;
            // 
            // saidaDataGridViewTextBoxColumn
            // 
            this.saidaDataGridViewTextBoxColumn.DataPropertyName = "Saida";
            this.saidaDataGridViewTextBoxColumn.HeaderText = "Saida";
            this.saidaDataGridViewTextBoxColumn.Name = "saidaDataGridViewTextBoxColumn";
            this.saidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.saidaDataGridViewTextBoxColumn.Width = 86;
            // 
            // debitoDataGridViewTextBoxColumn
            // 
            this.debitoDataGridViewTextBoxColumn.DataPropertyName = "Debito";
            this.debitoDataGridViewTextBoxColumn.HeaderText = "Debito";
            this.debitoDataGridViewTextBoxColumn.Name = "debitoDataGridViewTextBoxColumn";
            this.debitoDataGridViewTextBoxColumn.ReadOnly = true;
            this.debitoDataGridViewTextBoxColumn.Width = 96;
            // 
            // creditoDataGridViewTextBoxColumn
            // 
            this.creditoDataGridViewTextBoxColumn.DataPropertyName = "Credito";
            this.creditoDataGridViewTextBoxColumn.HeaderText = "Credito";
            this.creditoDataGridViewTextBoxColumn.Name = "creditoDataGridViewTextBoxColumn";
            this.creditoDataGridViewTextBoxColumn.ReadOnly = true;
            this.creditoDataGridViewTextBoxColumn.Width = 103;
            // 
            // totalCartaoDataGridViewTextBoxColumn
            // 
            this.totalCartaoDataGridViewTextBoxColumn.DataPropertyName = "Total_Cartao";
            this.totalCartaoDataGridViewTextBoxColumn.HeaderText = "Total_Cartao";
            this.totalCartaoDataGridViewTextBoxColumn.Name = "totalCartaoDataGridViewTextBoxColumn";
            this.totalCartaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCartaoDataGridViewTextBoxColumn.Width = 154;
            // 
            // totalEntradaDataGridViewTextBoxColumn
            // 
            this.totalEntradaDataGridViewTextBoxColumn.DataPropertyName = "Total_Entrada";
            this.totalEntradaDataGridViewTextBoxColumn.HeaderText = "Total_Entrada";
            this.totalEntradaDataGridViewTextBoxColumn.Name = "totalEntradaDataGridViewTextBoxColumn";
            this.totalEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalEntradaDataGridViewTextBoxColumn.Width = 162;
            // 
            // totalProdutosDataGridViewTextBoxColumn
            // 
            this.totalProdutosDataGridViewTextBoxColumn.DataPropertyName = "Total_Produtos";
            this.totalProdutosDataGridViewTextBoxColumn.HeaderText = "Total_Produtos";
            this.totalProdutosDataGridViewTextBoxColumn.Name = "totalProdutosDataGridViewTextBoxColumn";
            this.totalProdutosDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalProdutosDataGridViewTextBoxColumn.Width = 168;
            // 
            // totalEspecieDataGridViewTextBoxColumn
            // 
            this.totalEspecieDataGridViewTextBoxColumn.DataPropertyName = "Total_Especie";
            this.totalEspecieDataGridViewTextBoxColumn.HeaderText = "Total_Especie";
            this.totalEspecieDataGridViewTextBoxColumn.Name = "totalEspecieDataGridViewTextBoxColumn";
            this.totalEspecieDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalEspecieDataGridViewTextBoxColumn.Width = 157;
            // 
            // fundoDeCaixaDataGridViewTextBoxColumn
            // 
            this.fundoDeCaixaDataGridViewTextBoxColumn.DataPropertyName = "Fundo_De_Caixa";
            this.fundoDeCaixaDataGridViewTextBoxColumn.HeaderText = "Fundo_De_Caixa";
            this.fundoDeCaixaDataGridViewTextBoxColumn.Name = "fundoDeCaixaDataGridViewTextBoxColumn";
            this.fundoDeCaixaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fundoDeCaixaDataGridViewTextBoxColumn.Width = 192;
            // 
            // totalDepositoDataGridViewTextBoxColumn
            // 
            this.totalDepositoDataGridViewTextBoxColumn.DataPropertyName = "Total_Deposito";
            this.totalDepositoDataGridViewTextBoxColumn.HeaderText = "Total_Deposito";
            this.totalDepositoDataGridViewTextBoxColumn.Name = "totalDepositoDataGridViewTextBoxColumn";
            this.totalDepositoDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDepositoDataGridViewTextBoxColumn.Width = 168;
            // 
            // valorApresentadoDataGridViewTextBoxColumn
            // 
            this.valorApresentadoDataGridViewTextBoxColumn.DataPropertyName = "Valor_Apresentado";
            this.valorApresentadoDataGridViewTextBoxColumn.HeaderText = "Valor_Apresentado";
            this.valorApresentadoDataGridViewTextBoxColumn.Name = "valorApresentadoDataGridViewTextBoxColumn";
            this.valorApresentadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorApresentadoDataGridViewTextBoxColumn.Width = 216;
            // 
            // conclusaoDataGridViewTextBoxColumn
            // 
            this.conclusaoDataGridViewTextBoxColumn.DataPropertyName = "Conclusao";
            this.conclusaoDataGridViewTextBoxColumn.HeaderText = "Conclusao";
            this.conclusaoDataGridViewTextBoxColumn.Name = "conclusaoDataGridViewTextBoxColumn";
            this.conclusaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.conclusaoDataGridViewTextBoxColumn.Width = 133;
            // 
            // FrmBalanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 396);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dt2);
            this.Controls.Add(this.dt1);
            this.Controls.Add(this.Grid);
            this.Name = "FrmBalanco";
            this.Text = "Balanço por Período";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBalanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblResumoDeCaixasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridBase Grid;
        private DataSource dataSource;
        private System.Windows.Forms.DateTimePicker dt1;
        private System.Windows.Forms.DateTimePicker dt2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tblResumoDeCaixasBindingSource;
        private DataSourceTableAdapters.tblResumo_De_CaixasTableAdapter tblResumo_De_CaixasTableAdapter;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinheiroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCartaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalProdutosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalEspecieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundoDeCaixaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDepositoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorApresentadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conclusaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel10;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel12;

    }
}