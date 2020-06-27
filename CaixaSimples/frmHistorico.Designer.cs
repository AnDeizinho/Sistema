namespace CaixaSimples
{
    partial class frmHistorico
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
            this.lista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtData = new System.Windows.Forms.DateTimePicker();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnBalanco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lista.ForeColor = System.Drawing.Color.Navy;
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 22;
            this.lista.Location = new System.Drawing.Point(12, 43);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(164, 220);
            this.lista.TabIndex = 0;
            this.lista.Click += new System.EventHandler(this.lista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caixas Recentes :";
            // 
            // DtData
            // 
            this.DtData.CalendarForeColor = System.Drawing.Color.Navy;
            this.DtData.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtData.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.DtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtData.Location = new System.Drawing.Point(185, 12);
            this.DtData.Name = "DtData";
            this.DtData.Size = new System.Drawing.Size(245, 31);
            this.DtData.TabIndex = 2;
            // 
            // btnAbrir
            // 
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Location = new System.Drawing.Point(185, 197);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(245, 70);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnBalanco
            // 
            this.btnBalanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalanco.Location = new System.Drawing.Point(185, 121);
            this.btnBalanco.Name = "btnBalanco";
            this.btnBalanco.Size = new System.Drawing.Size(245, 70);
            this.btnBalanco.TabIndex = 4;
            this.btnBalanco.Text = "Balanço";
            this.btnBalanco.UseVisualStyleBackColor = true;
            this.btnBalanco.Click += new System.EventHandler(this.btnBalanco_Click);
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 290);
            this.Controls.Add(this.btnBalanco);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.DtData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista);
            this.Name = "frmHistorico";
            this.Text = "Hitórico de Caixa";
            this.Load += new System.EventHandler(this.frmHistorico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtData;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnBalanco;
    }
}