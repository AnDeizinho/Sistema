namespace CaixaSimples.Pagamento
{
    partial class frmPagamento
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
            this.dt_ano = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dt_ano)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_ano
            // 
            this.dt_ano.AllowUserToAddRows = false;
            this.dt_ano.AllowUserToDeleteRows = false;
            this.dt_ano.AllowUserToResizeColumns = false;
            this.dt_ano.AllowUserToResizeRows = false;
            this.dt_ano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_ano.Location = new System.Drawing.Point(30, 26);
            this.dt_ano.MultiSelect = false;
            this.dt_ano.Name = "dt_ano";
            this.dt_ano.ReadOnly = true;
            this.dt_ano.RowHeadersVisible = false;
            this.dt_ano.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_ano.Size = new System.Drawing.Size(240, 150);
            this.dt_ano.TabIndex = 0;
            this.dt_ano.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_ano_CellDoubleClick);
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 214);
            this.Controls.Add(this.dt_ano);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPagamento";
            this.Text = "Formulário de Pagamento";
            
            ((System.ComponentModel.ISupportInitialize)(this.dt_ano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_ano;

    }
}