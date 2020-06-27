namespace CaixaSimples
{
    partial class CHcontratoboletoDT
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
            this.dt = new CaixaSimples.DataGridBase();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AllowUserToDeleteRows = false;
            this.dt.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Location = new System.Drawing.Point(12, 12);
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.RowHeadersVisible = false;
            this.dt.Size = new System.Drawing.Size(488, 297);
            this.dt.TabIndex = 0;
            // 
            // CHcontratoboletoDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(512, 322);
            this.Controls.Add(this.dt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.Name = "CHcontratoboletoDT";
            this.Text = "CHcontratoboletoDT";
            this.Load += new System.EventHandler(this.CHcontratoboletoDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridBase dt;
    }
}