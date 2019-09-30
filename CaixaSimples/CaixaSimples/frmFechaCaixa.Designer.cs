namespace CaixaSimples
{
    partial class frmFechaCaixa
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
            this.btnFecha = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFecha
            // 
            this.btnFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecha.Location = new System.Drawing.Point(16, 39);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(364, 46);
            this.btnFecha.TabIndex = 5;
            this.btnFecha.Text = "Fechar Caixa";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.ForeColor = System.Drawing.Color.Navy;
            this.txtValor.Location = new System.Drawing.Point(209, 9);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(171, 24);
            this.txtValor.TabIndex = 4;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor Apresentado:";
            // 
            // frmFechaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.ClientSize = new System.Drawing.Size(392, 96);
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "frmFechaCaixa";
            this.Load += new System.EventHandler(this.frmFechaCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnFecha;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.Label label1;
    }
}