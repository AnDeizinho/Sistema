namespace CaixaSimples
{
    partial class frmContratoBoleto
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
            this.dtAnos = new CaixaSimples.DataGridBase();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbnNovo = new System.Windows.Forms.Button();
            this.pn = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtAnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtAnos
            // 
            this.dtAnos.AllowUserToAddRows = false;
            this.dtAnos.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dtAnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtAnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAnos.Location = new System.Drawing.Point(12, 82);
            this.dtAnos.Name = "dtAnos";
            this.dtAnos.ReadOnly = true;
            this.dtAnos.RowHeadersVisible = false;
            this.dtAnos.Size = new System.Drawing.Size(213, 251);
            this.dtAnos.TabIndex = 5;
            this.dtAnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAnos_CellDoubleClick);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(231, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(65, 22);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "label2";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(12, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(65, 22);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "label1";
            // 
            // tbnNovo
            // 
            this.tbnNovo.Location = new System.Drawing.Point(12, 351);
            this.tbnNovo.Name = "tbnNovo";
            this.tbnNovo.Size = new System.Drawing.Size(202, 53);
            this.tbnNovo.TabIndex = 2;
            this.tbnNovo.Text = "Novo Contrato";
            this.tbnNovo.UseVisualStyleBackColor = true;
            this.tbnNovo.Click += new System.EventHandler(this.tbnNovo_Click);
            // 
            // pn
            // 
            this.pn.BackColor = System.Drawing.Color.SteelBlue;
            this.pn.Location = new System.Drawing.Point(235, 82);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(512, 322);
            this.pn.TabIndex = 1;
            // 
            // frmContratoBoleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 428);
            this.Controls.Add(this.dtAnos);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbnNovo);
            this.Controls.Add(this.pn);
            this.Name = "frmContratoBoleto";
            this.ShowInTaskbar = true;
            this.Text = "Contratos";
            this.Load += new System.EventHandler(this.frmContratoBoleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtAnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Button tbnNovo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private DataGridBase dtAnos;
    }
}