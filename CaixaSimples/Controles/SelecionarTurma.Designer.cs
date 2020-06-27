namespace CaixaSimples.Controles
{
    partial class SelecionarTurma
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ltTurmas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ltTurmas
            // 
            this.ltTurmas.FormattingEnabled = true;
            this.ltTurmas.ItemHeight = 22;
            this.ltTurmas.Location = new System.Drawing.Point(25, 14);
            this.ltTurmas.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ltTurmas.Name = "ltTurmas";
            this.ltTurmas.Size = new System.Drawing.Size(619, 400);
            this.ltTurmas.TabIndex = 0;
            this.ltTurmas.DoubleClick += new System.EventHandler(this.ltTurmas_DoubleClick);
            this.ltTurmas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ltTurmas_KeyDown);
            // 
            // SelecionarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 454);
            this.Controls.Add(this.ltTurmas);
            this.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.Name = "SelecionarTurma";
            this.Load += new System.EventHandler(this.SelecionarTurma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ltTurmas;
    }
}
