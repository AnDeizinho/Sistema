namespace CaixaSimples
{
    partial class frmTurmas
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
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.cadastrarTurmas1 = new SistemaShekinahCompleto.Views.ViewsSecretaria.CadastrarTurmas();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.BackColor = System.Drawing.Color.Purple;
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.ForeColor = System.Drawing.Color.Black;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(902, 535);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.cadastrarTurmas1;
            // 
            // frmTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 535);
            this.Controls.Add(this.elementHost1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "frmTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turmas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private SistemaShekinahCompleto.Views.ViewsSecretaria.CadastrarTurmas cadastrarTurmas1;
    }
}