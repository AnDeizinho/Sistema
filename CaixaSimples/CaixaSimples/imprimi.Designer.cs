namespace CaixaSimples
{
    partial class imprimi
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BSmensalidade = new System.Windows.Forms.BindingSource(this.components);
            this.DataSource = new CaixaSimples.DataSource();
            this.BSdeposito = new System.Windows.Forms.BindingSource(this.components);
            this.BSsaida = new System.Windows.Forms.BindingSource(this.components);
            this.BSproduto = new System.Windows.Forms.BindingSource(this.components);
            this.BSresumo = new System.Windows.Forms.BindingSource(this.components);
            this.reportar = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblDepositoTableAdapter = new CaixaSimples.DataSourceTableAdapters.tblDepositoTableAdapter();
            this.tblSaidaTableAdapter = new CaixaSimples.DataSourceTableAdapters.tblSaidaTableAdapter();
            this.tblProdutosTableAdapter = new CaixaSimples.DataSourceTableAdapters.tblProdutosTableAdapter();
            this.tblResumo_De_CaixasTableAdapter = new CaixaSimples.DataSourceTableAdapters.tblResumo_De_CaixasTableAdapter();
            this.bDcaixaDataSet = new CaixaSimples.BDcaixaDataSet();
            this.tblMensalidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_MensalidadeTableAdapter = new CaixaSimples.BDcaixaDataSetTableAdapters.tbl_MensalidadeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BSmensalidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSdeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSsaida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSproduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSresumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDcaixaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMensalidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BSmensalidade
            // 
            this.BSmensalidade.DataMember = "tbl_Mensalidade";
            this.BSmensalidade.DataSource = this.DataSource;
            // 
            // DataSource
            // 
            this.DataSource.DataSetName = "DataSource";
            this.DataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BSdeposito
            // 
            this.BSdeposito.DataMember = "tblDeposito";
            this.BSdeposito.DataSource = this.DataSource;
            // 
            // BSsaida
            // 
            this.BSsaida.DataMember = "tblSaida";
            this.BSsaida.DataSource = this.DataSource;
            // 
            // BSproduto
            // 
            this.BSproduto.DataMember = "tblProdutos";
            this.BSproduto.DataSource = this.DataSource;
            // 
            // BSresumo
            // 
            this.BSresumo.DataMember = "tblResumo_De_Caixas";
            this.BSresumo.DataSource = this.DataSource;
            // 
            // reportar
            // 
            this.reportar.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "deposito";
            reportDataSource1.Value = this.BSdeposito;
            reportDataSource2.Name = "saida";
            reportDataSource2.Value = this.BSsaida;
            reportDataSource3.Name = "produto";
            reportDataSource3.Value = this.BSproduto;
            reportDataSource4.Name = "resumo";
            reportDataSource4.Value = this.BSresumo;
            reportDataSource5.Name = "DataSet1";
            reportDataSource5.Value = this.tblMensalidadeBindingSource;
            this.reportar.LocalReport.DataSources.Add(reportDataSource1);
            this.reportar.LocalReport.DataSources.Add(reportDataSource2);
            this.reportar.LocalReport.DataSources.Add(reportDataSource3);
            this.reportar.LocalReport.DataSources.Add(reportDataSource4);
            this.reportar.LocalReport.DataSources.Add(reportDataSource5);
            this.reportar.LocalReport.ReportEmbeddedResource = "CaixaSimples.Rlatorios.rdlc";
            this.reportar.Location = new System.Drawing.Point(0, 0);
            this.reportar.Name = "reportar";
            this.reportar.Size = new System.Drawing.Size(442, 219);
            this.reportar.TabIndex = 0;
            // 
            // tblDepositoTableAdapter
            // 
            this.tblDepositoTableAdapter.ClearBeforeFill = true;
            // 
            // tblSaidaTableAdapter
            // 
            this.tblSaidaTableAdapter.ClearBeforeFill = true;
            // 
            // tblProdutosTableAdapter
            // 
            this.tblProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // tblResumo_De_CaixasTableAdapter
            // 
            this.tblResumo_De_CaixasTableAdapter.ClearBeforeFill = true;
            // 
            // bDcaixaDataSet
            // 
            this.bDcaixaDataSet.DataSetName = "BDcaixaDataSet";
            this.bDcaixaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // imprimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.ClientSize = new System.Drawing.Size(442, 219);
            this.Controls.Add(this.reportar);
            this.Name = "imprimi";
            this.Text = "Imprimir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.imprimi_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.BSmensalidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSdeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSsaida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSproduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSresumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDcaixaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMensalidadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportar;
        private System.Windows.Forms.BindingSource tbl_MensalidadeBindingSource;
        //private dataSource dataSource;
        private System.Windows.Forms.BindingSource tblResumo_De_CaixasBindingSource;
        private System.Windows.Forms.BindingSource dataSourceBindingSource;
        //private dataSourceTableAdapters.tbl_MensalidadeTableAdapter tbl_MensalidadeTableAdapter;
        //private dataSourceTableAdapters.tblResumo_De_CaixasTableAdapter tblResumo_De_CaixasTableAdapter;
        private System.Windows.Forms.BindingSource tblSaidaBindingSource;
        //private dataSourceTableAdapters.tblSaidaTableAdapter tblSaidaTableAdapter;
        private System.Windows.Forms.BindingSource tblProdutosBindingSource;
        //private dataSourceTableAdapters.tblProdutosTableAdapter tblProdutosTableAdapter;
        private System.Windows.Forms.BindingSource tblDepositoBindingSource;
        private DataSource DataSource;
        private System.Windows.Forms.BindingSource BSdeposito;
        private DataSourceTableAdapters.tblDepositoTableAdapter tblDepositoTableAdapter;
        private System.Windows.Forms.BindingSource BSsaida;
        private DataSourceTableAdapters.tblSaidaTableAdapter tblSaidaTableAdapter;
        private System.Windows.Forms.BindingSource BSproduto;
        private DataSourceTableAdapters.tblProdutosTableAdapter tblProdutosTableAdapter;
        private System.Windows.Forms.BindingSource BSresumo;
        private DataSourceTableAdapters.tblResumo_De_CaixasTableAdapter tblResumo_De_CaixasTableAdapter;
        private System.Windows.Forms.BindingSource BSmensalidade;
        private BDcaixaDataSet bDcaixaDataSet;
        private System.Windows.Forms.BindingSource tblMensalidadeBindingSource;
        private BDcaixaDataSetTableAdapters.tbl_MensalidadeTableAdapter tbl_MensalidadeTableAdapter;
        //private dataSourceTableAdapters.tblDepositoTableAdapter tblDepositoTableAdapter;
    }
}