namespace CaixaSimples
{
    partial class frmRelatorioBalanco
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
            this.tblResumo_De_CaixasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSource = new CaixaSimples.DataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblResumo_De_CaixasTableAdapter = new CaixaSimples.DataSourceTableAdapters.tblResumo_De_CaixasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblResumo_De_CaixasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblResumo_De_CaixasBindingSource
            // 
            this.tblResumo_De_CaixasBindingSource.DataMember = "tblResumo_De_Caixas";
            this.tblResumo_De_CaixasBindingSource.DataSource = this.DataSource;
            // 
            // DataSource
            // 
            this.DataSource.DataSetName = "DataSource";
            this.DataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Resumos";
            reportDataSource1.Value = this.tblResumo_De_CaixasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CaixaSimples.Balanco.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(442, 215);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblResumo_De_CaixasTableAdapter
            // 
            this.tblResumo_De_CaixasTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioBalanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 215);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioBalanco";
            this.Text = "Relatório do Balanço";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRelatorioBalanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblResumo_De_CaixasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblResumo_De_CaixasBindingSource;
        private DataSource DataSource;
        private DataSourceTableAdapters.tblResumo_De_CaixasTableAdapter tblResumo_De_CaixasTableAdapter;
    }
}