namespace CaixaSimples
{
    partial class frmAbriCaixa
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
        public virtual void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFundo = new System.Windows.Forms.TextBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fundo de Caixa :";
            // 
            // txtFundo
            // 
            this.txtFundo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFundo.ForeColor = System.Drawing.Color.Navy;
            this.txtFundo.Location = new System.Drawing.Point(184, 9);
            this.txtFundo.Name = "txtFundo";
            this.txtFundo.Size = new System.Drawing.Size(196, 24);
            this.txtFundo.TabIndex = 1;
            this.txtFundo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAbrir
            // 
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Location = new System.Drawing.Point(16, 39);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(364, 46);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Abrir Caixa";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frmAbriCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 102);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.txtFundo);
            this.Controls.Add(this.label1);
            this.Name = "frmAbriCaixa";
            this.Text = "Abrir Caixa";
            this.Load += new System.EventHandler(this.frmAbriCaixa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtFundo;
        public System.Windows.Forms.Button btnAbrir;
    }
}