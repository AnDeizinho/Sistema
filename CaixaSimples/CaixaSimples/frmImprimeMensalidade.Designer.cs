namespace CaixaSimples
{
    partial class frmImprimeMensalidade
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BDAtaFinalDataSet = new CaixaSimples.BDAtaFinalDataSet();
            this.tbl_AlunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_AlunosTableAdapter = new CaixaSimples.BDAtaFinalDataSetTableAdapters.tbl_AlunosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BDAtaFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_AlunosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "tblAlunos";
            reportDataSource1.Value = this.tbl_AlunosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CaixaSimples.Mensalidade.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(442, 215);
            this.reportViewer1.TabIndex = 0;
            // 
            // BDAtaFinalDataSet
            // 
            this.BDAtaFinalDataSet.DataSetName = "BDAtaFinalDataSet";
            this.BDAtaFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_AlunosBindingSource
            // 
            this.tbl_AlunosBindingSource.DataMember = "tbl_Alunos";
            this.tbl_AlunosBindingSource.DataSource = this.BDAtaFinalDataSet;
            // 
            // tbl_AlunosTableAdapter
            // 
            this.tbl_AlunosTableAdapter.ClearBeforeFill = true;
            // 
            // frmImprimeMensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 215);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Name = "frmImprimeMensalidade";
            this.Text = "Recibo de Mensalidade";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImprimeMensalidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BDAtaFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_AlunosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_AlunosBindingSource;
        private BDAtaFinalDataSet BDAtaFinalDataSet;
        private BDAtaFinalDataSetTableAdapters.tbl_AlunosTableAdapter tbl_AlunosTableAdapter;
    }
}