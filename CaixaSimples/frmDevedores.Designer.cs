using System.Runtime.CompilerServices;

namespace CaixaSimples
{
    partial class frmDevedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevedores));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDDevedores = new CaixaSimples.BDDevedores();
            this.tbl_clienteTableAdapter = new CaixaSimples.BDDevedoresTableAdapters.tbl_clienteTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cbInicio = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbFinal = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDDevedores)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "NovoDTDevedores";
            reportDataSource1.Value = this.tbl_clienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CaixaSimples.relatiorioDevedores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(521, 414);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbl_clienteBindingSource
            // 
            this.tbl_clienteBindingSource.DataMember = "tbl_cliente";
            this.tbl_clienteBindingSource.DataSource = this.BDDevedores;
            // 
            // BDDevedores
            // 
            this.BDDevedores.DataSetName = "BDDevedores";
            this.BDDevedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_clienteTableAdapter
            // 
            this.tbl_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cbInicio,
            this.toolStripLabel2,
            this.cbFinal,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(521, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "Mês Inicial";
            // 
            // cbInicio
            // 
            this.cbInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInicio.ForeColor = System.Drawing.Color.Navy;
            this.cbInicio.Items.AddRange(new object[] {
            "<INICIAL>",
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
            this.cbInicio.Name = "cbInicio";
            this.cbInicio.Size = new System.Drawing.Size(121, 25);
            this.cbInicio.SelectedIndexChanged += new System.EventHandler(this.cbInicio_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(57, 22);
            this.toolStripLabel2.Text = "Mês Final";
            // 
            // cbFinal
            // 
            this.cbFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFinal.ForeColor = System.Drawing.Color.Navy;
            this.cbFinal.Items.AddRange(new object[] {
            "<FINAL>",
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
            this.cbFinal.Name = "cbFinal";
            this.cbFinal.Size = new System.Drawing.Size(121, 25);
            this.cbFinal.SelectedIndexChanged += new System.EventHandler(this.cbFinal_SelectedIndexChanged);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(39, 22);
            this.toolStripButton1.Text = "Gerar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmDevedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 442);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.Name = "frmDevedores";
            this.Text = "Devedores de ";
            this.Load += new System.EventHandler(this.frmDevedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDDevedores)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_clienteBindingSource;
        private BDDevedores BDDevedores;
        private BDDevedoresTableAdapters.tbl_clienteTableAdapter tbl_clienteTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cbInicio;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbFinal;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}