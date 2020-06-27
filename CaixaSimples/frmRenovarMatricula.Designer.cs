namespace CaixaSimples
{
    partial class frmRenovarMatricula
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbsituacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbserie = new System.Windows.Forms.ComboBox();
            this.cbturno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtAta = new CaixaSimples.DataGridBase();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAtual = new System.Windows.Forms.TextBox();
            this.lsturmas = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtAta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Série Atual :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Situação :";
            // 
            // cbsituacao
            // 
            this.cbsituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsituacao.FormattingEnabled = true;
            this.cbsituacao.Items.AddRange(new object[] {
            "situaçao",
            "AP",
            "R"});
            this.cbsituacao.Location = new System.Drawing.Point(415, 280);
            this.cbsituacao.Name = "cbsituacao";
            this.cbsituacao.Size = new System.Drawing.Size(152, 30);
            this.cbsituacao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Próxima Série :";
            // 
            // cbserie
            // 
            this.cbserie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbserie.FormattingEnabled = true;
            this.cbserie.Items.AddRange(new object[] {
            "Serie",
            "1° Ano                                            ",
            "2° Ano                                            ",
            "3° Ano                                            ",
            "4° Ano                                            ",
            "5° Ano                                            ",
            "Pré Maternal                                      ",
            "Maternal                                          ",
            "1º Período                                        ",
            "2º Período                                        "});
            this.cbserie.Location = new System.Drawing.Point(155, 345);
            this.cbserie.Name = "cbserie";
            this.cbserie.Size = new System.Drawing.Size(152, 30);
            this.cbserie.TabIndex = 7;
            // 
            // cbturno
            // 
            this.cbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbturno.FormattingEnabled = true;
            this.cbturno.Items.AddRange(new object[] {
            "Turno",
            "Matutino",
            "Vespertino"});
            this.cbturno.Location = new System.Drawing.Point(415, 340);
            this.cbturno.Name = "cbturno";
            this.cbturno.Size = new System.Drawing.Size(152, 30);
            this.cbturno.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Turno :";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 226);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(96, 22);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Aluno(a):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Renovar";
            this.button1.UseVisualStyleBackColor = true;
            //this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 52);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dtAta
            // 
            this.dtAta.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dtAta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtAta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAta.Location = new System.Drawing.Point(430, 43);
            this.dtAta.Name = "dtAta";
            this.dtAta.ReadOnly = true;
            this.dtAta.RowHeadersVisible = false;
            this.dtAta.Size = new System.Drawing.Size(399, 185);
            this.dtAta.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ano :";
            // 
            // txtAtual
            // 
            this.txtAtual.Enabled = false;
            this.txtAtual.Location = new System.Drawing.Point(134, 280);
            this.txtAtual.Name = "txtAtual";
            this.txtAtual.Size = new System.Drawing.Size(152, 31);
            this.txtAtual.TabIndex = 16;
            // 
            // lsturmas
            // 
            this.lsturmas.FormattingEnabled = true;
            this.lsturmas.ItemHeight = 22;
            this.lsturmas.Location = new System.Drawing.Point(12, 43);
            this.lsturmas.Name = "lsturmas";
            this.lsturmas.Size = new System.Drawing.Size(412, 180);
            this.lsturmas.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Aluno(a):";
            // 
            // frmRenovarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 503);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lsturmas);
            this.Controls.Add(this.txtAtual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dtAta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbturno);
            this.Controls.Add(this.cbserie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbsituacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.Name = "frmRenovarMatricula";
            this.Text = "Renovação de Matrícula";
            this.Load += new System.EventHandler(this.frmRenovarMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtAta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbsituacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbserie;
        private System.Windows.Forms.ComboBox cbturno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DataGridBase dtAta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAtual;
        private System.Windows.Forms.ListBox lsturmas;
        private System.Windows.Forms.Label label5;
    }
}