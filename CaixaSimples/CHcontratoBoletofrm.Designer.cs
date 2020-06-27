namespace CaixaSimples
{
    partial class CHcontratoBoletofrm
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
            this.CH = new System.Windows.Forms.CheckedListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtano = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtcb = new System.Windows.Forms.TextBox();
            this.txtminimo = new System.Windows.Forms.TextBox();
            this.txttaxa = new System.Windows.Forms.TextBox();
            this.txtvencimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbl_MesTableAdapter1 = new CaixaSimples.DSBoletosTableAdapters.tbl_MesTableAdapter();
            this.SuspendLayout();
            // 
            // CH
            // 
            this.CH.ForeColor = System.Drawing.Color.Navy;
            this.CH.FormattingEnabled = true;
            this.CH.Items.AddRange(new object[] {
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
            this.CH.Location = new System.Drawing.Point(12, 25);
            this.CH.Name = "CH";
            this.CH.Size = new System.Drawing.Size(202, 264);
            this.CH.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(238, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 42);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtano
            // 
            this.txtano.ForeColor = System.Drawing.Color.Navy;
            this.txtano.Location = new System.Drawing.Point(248, 60);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(100, 31);
            this.txtano.TabIndex = 2;
            this.txtano.Text = "2020";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.ForeColor = System.Drawing.Color.Navy;
            this.txtValor.Location = new System.Drawing.Point(400, 60);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 31);
            this.txtValor.TabIndex = 3;
            this.txtValor.Text = "0,0";
            // 
            // txtcb
            // 
            this.txtcb.ForeColor = System.Drawing.Color.Navy;
            this.txtcb.Location = new System.Drawing.Point(248, 128);
            this.txtcb.Name = "txtcb";
            this.txtcb.Size = new System.Drawing.Size(100, 31);
            this.txtcb.TabIndex = 4;
            this.txtcb.Text = "0";
            // 
            // txtminimo
            // 
            this.txtminimo.ForeColor = System.Drawing.Color.Navy;
            this.txtminimo.Location = new System.Drawing.Point(400, 128);
            this.txtminimo.Name = "txtminimo";
            this.txtminimo.Size = new System.Drawing.Size(100, 31);
            this.txtminimo.TabIndex = 5;
            this.txtminimo.Text = "300,00";
            // 
            // txttaxa
            // 
            this.txttaxa.ForeColor = System.Drawing.Color.Navy;
            this.txttaxa.Location = new System.Drawing.Point(400, 196);
            this.txttaxa.Name = "txttaxa";
            this.txttaxa.Size = new System.Drawing.Size(100, 31);
            this.txttaxa.TabIndex = 6;
            this.txttaxa.Text = "20,00";
            // 
            // txtvencimento
            // 
            this.txtvencimento.ForeColor = System.Drawing.Color.Navy;
            this.txtvencimento.Location = new System.Drawing.Point(248, 196);
            this.txtvencimento.Name = "txtvencimento";
            this.txtvencimento.Size = new System.Drawing.Size(100, 31);
            this.txtvencimento.TabIndex = 7;
            this.txtvencimento.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ano :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor Integral :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "CB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Com Desconto :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vencimento :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Taxa Atraso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Renovar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbl_MesTableAdapter1
            // 
            this.tbl_MesTableAdapter1.ClearBeforeFill = true;
            // 
            // CHcontratoBoletofrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(512, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtvencimento);
            this.Controls.Add(this.txttaxa);
            this.Controls.Add(this.txtminimo);
            this.Controls.Add(this.txtcb);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.CH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.Name = "CHcontratoBoletofrm";
            this.Text = "CHcontratoBoletofrm";
            this.Load += new System.EventHandler(this.CHcontratoBoletofrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSBoletosTableAdapters.tbl_MesTableAdapter tbl_MesTableAdapter1;
        private System.Windows.Forms.CheckedListBox CH;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtcb;
        private System.Windows.Forms.TextBox txtminimo;
        private System.Windows.Forms.TextBox txttaxa;
        private System.Windows.Forms.TextBox txtvencimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}