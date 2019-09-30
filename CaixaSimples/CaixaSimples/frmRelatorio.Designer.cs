namespace CaixaSimples
{
    partial class frmRelatorio
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
            this.btnImprimi = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.lblTabela = new System.Windows.Forms.Label();
            this.gridBase = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridBase)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimi
            // 
            this.btnImprimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimi.Location = new System.Drawing.Point(798, 418);
            this.btnImprimi.Name = "btnImprimi";
            this.btnImprimi.Size = new System.Drawing.Size(232, 87);
            this.btnImprimi.TabIndex = 2;
            this.btnImprimi.Text = "Imprimir";
            this.btnImprimi.UseVisualStyleBackColor = true;
            this.btnImprimi.Click += new System.EventHandler(this.btnImprimi_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Location = new System.Drawing.Point(798, 316);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(232, 87);
            this.btnProximo.TabIndex = 1;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // lblTabela
            // 
            this.lblTabela.AutoSize = true;
            this.lblTabela.Location = new System.Drawing.Point(854, 12);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(135, 22);
            this.lblTabela.TabIndex = 1;
            this.lblTabela.Text = "Mensalidades";
            // 
            // gridBase
            // 
            this.gridBase.AllowUserToAddRows = false;
            this.gridBase.AllowUserToDeleteRows = false;
            this.gridBase.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.gridBase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBase.GridColor = System.Drawing.Color.SkyBlue;
            this.gridBase.Location = new System.Drawing.Point(12, 12);
            this.gridBase.Name = "gridBase";
            this.gridBase.ReadOnly = true;
            this.gridBase.RowHeadersVisible = false;
            this.gridBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBase.Size = new System.Drawing.Size(780, 498);
            this.gridBase.TabIndex = 0;
            this.gridBase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBase_CellContentClick);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 518);
            this.Controls.Add(this.btnImprimi);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.lblTabela);
            this.Controls.Add(this.gridBase);
            this.Name = "frmRelatorio";
            this.Text = "Relatório do Dia";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBase;
        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnImprimi;
    }
}