namespace CaixaSimples
{
    partial class frmAluno
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
            this.components = new System.ComponentModel.Container();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.tblMensalidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSource = new CaixaSimples.DataSource();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.txtremedio = new System.Windows.Forms.TextBox();
            this.txtclinicos = new System.Windows.Forms.TextBox();
            this.txtuf = new System.Windows.Forms.TextBox();
            this.txtnat = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tbl_MensalidadeTableAdapter = new CaixaSimples.DataSourceTableAdapters.tbl_MensalidadeTableAdapter();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mask = new System.Windows.Forms.MaskedTextBox();
            this.btnDes = new System.Windows.Forms.Button();
            this.cbIntegral = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbTurma = new System.Windows.Forms.TextBox();
            this.btnturma = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblMensalidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(41, 280);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(44, 25);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 243);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Remédios:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 207);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Dados Clínicos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "UF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Naturalidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Turma :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CC :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome do Aluno:";
            // 
            // cb
            // 
            this.cb.BackColor = System.Drawing.Color.White;
            this.cb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblMensalidadeBindingSource, "Data", true));
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb.ForeColor = System.Drawing.Color.Navy;
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "SEXO",
            "M",
            "F"});
            this.cb.Location = new System.Drawing.Point(280, 155);
            this.cb.Margin = new System.Windows.Forms.Padding(2);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(69, 21);
            this.cb.TabIndex = 8;
            // 
            // tblMensalidadeBindingSource
            // 
            this.tblMensalidadeBindingSource.DataMember = "tbl_Mensalidade";
            this.tblMensalidadeBindingSource.DataSource = this.dataSource;
            // 
            // dataSource
            // 
            this.dataSource.DataSetName = "DataSource";
            this.dataSource.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(203, 128);
            this.data.Margin = new System.Windows.Forms.Padding(2);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(91, 20);
            this.data.TabIndex = 5;
            // 
            // txtremedio
            // 
            this.txtremedio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtremedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtremedio.ForeColor = System.Drawing.Color.Navy;
            this.txtremedio.Location = new System.Drawing.Point(39, 260);
            this.txtremedio.Margin = new System.Windows.Forms.Padding(2);
            this.txtremedio.MaxLength = 150;
            this.txtremedio.Multiline = true;
            this.txtremedio.Name = "txtremedio";
            this.txtremedio.Size = new System.Drawing.Size(307, 17);
            this.txtremedio.TabIndex = 12;
            // 
            // txtclinicos
            // 
            this.txtclinicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtclinicos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclinicos.ForeColor = System.Drawing.Color.Navy;
            this.txtclinicos.Location = new System.Drawing.Point(41, 224);
            this.txtclinicos.Margin = new System.Windows.Forms.Padding(2);
            this.txtclinicos.MaxLength = 150;
            this.txtclinicos.Multiline = true;
            this.txtclinicos.Name = "txtclinicos";
            this.txtclinicos.Size = new System.Drawing.Size(307, 17);
            this.txtclinicos.TabIndex = 11;
            // 
            // txtuf
            // 
            this.txtuf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtuf.ForeColor = System.Drawing.Color.Navy;
            this.txtuf.Location = new System.Drawing.Point(228, 156);
            this.txtuf.Margin = new System.Windows.Forms.Padding(2);
            this.txtuf.MaxLength = 2;
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(38, 13);
            this.txtuf.TabIndex = 7;
            // 
            // txtnat
            // 
            this.txtnat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnat.ForeColor = System.Drawing.Color.Navy;
            this.txtnat.Location = new System.Drawing.Point(116, 156);
            this.txtnat.Margin = new System.Windows.Forms.Padding(2);
            this.txtnat.MaxLength = 20;
            this.txtnat.Name = "txtnat";
            this.txtnat.Size = new System.Drawing.Size(86, 13);
            this.txtnat.TabIndex = 6;
            // 
            // txtCod
            // 
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.Enabled = false;
            this.txtCod.ForeColor = System.Drawing.Color.Navy;
            this.txtCod.Location = new System.Drawing.Point(78, 56);
            this.txtCod.Margin = new System.Windows.Forms.Padding(2);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(55, 13);
            this.txtCod.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.ForeColor = System.Drawing.Color.Navy;
            this.txtNome.Location = new System.Drawing.Point(126, 36);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 13);
            this.txtNome.TabIndex = 1;
            // 
            // tbl_MensalidadeTableAdapter
            // 
            this.tbl_MensalidadeTableAdapter.ClearBeforeFill = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(278, 56);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Ano :";
            // 
            // txtAno
            // 
            this.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAno.ForeColor = System.Drawing.Color.Navy;
            this.txtAno.Location = new System.Drawing.Point(314, 56);
            this.txtAno.Margin = new System.Windows.Forms.Padding(2);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(32, 13);
            this.txtAno.TabIndex = 3;
            this.txtAno.Text = "2019";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 183);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Codigo Do MAC:";
            // 
            // mask
            // 
            this.mask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mask.ForeColor = System.Drawing.Color.Navy;
            this.mask.Location = new System.Drawing.Point(131, 183);
            this.mask.Margin = new System.Windows.Forms.Padding(2);
            this.mask.Mask = "000 000 000 000";
            this.mask.Name = "mask";
            this.mask.Size = new System.Drawing.Size(79, 13);
            this.mask.TabIndex = 9;
            // 
            // btnDes
            // 
            this.btnDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDes.Location = new System.Drawing.Point(88, 280);
            this.btnDes.Margin = new System.Windows.Forms.Padding(2);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(60, 25);
            this.btnDes.TabIndex = 14;
            this.btnDes.Text = "Cancelar";
            this.btnDes.UseVisualStyleBackColor = true;
            // 
            // cbIntegral
            // 
            this.cbIntegral.BackColor = System.Drawing.Color.White;
            this.cbIntegral.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblMensalidadeBindingSource, "Data", true));
            this.cbIntegral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntegral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIntegral.ForeColor = System.Drawing.Color.Navy;
            this.cbIntegral.FormattingEnabled = true;
            this.cbIntegral.Items.AddRange(new object[] {
            "integral",
            "não",
            "Sim"});
            this.cbIntegral.Location = new System.Drawing.Point(279, 181);
            this.cbIntegral.Margin = new System.Windows.Forms.Padding(2);
            this.cbIntegral.Name = "cbIntegral";
            this.cbIntegral.Size = new System.Drawing.Size(70, 21);
            this.cbIntegral.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(151, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 25);
            this.button1.TabIndex = 37;
            this.button1.Text = "Renovar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbTurma
            // 
            this.cbTurma.Enabled = false;
            this.cbTurma.Location = new System.Drawing.Point(78, 76);
            this.cbTurma.Margin = new System.Windows.Forms.Padding(2);
            this.cbTurma.Multiline = true;
            this.cbTurma.Name = "cbTurma";
            this.cbTurma.Size = new System.Drawing.Size(271, 49);
            this.cbTurma.TabIndex = 38;
            this.cbTurma.Text = "selecione uma turma";
            // 
            // btnturma
            // 
            this.btnturma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnturma.Location = new System.Drawing.Point(41, 127);
            this.btnturma.Margin = new System.Windows.Forms.Padding(2);
            this.btnturma.Name = "btnturma";
            this.btnturma.Size = new System.Drawing.Size(92, 19);
            this.btnturma.TabIndex = 39;
            this.btnturma.Text = "Selecinar turma";
            this.btnturma.UseVisualStyleBackColor = true;
            this.btnturma.Click += new System.EventHandler(this.btnturma_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "CA :";
            // 
            // txtCA
            // 
            this.txtCA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCA.Enabled = false;
            this.txtCA.ForeColor = System.Drawing.Color.Navy;
            this.txtCA.Location = new System.Drawing.Point(201, 56);
            this.txtCA.Margin = new System.Windows.Forms.Padding(2);
            this.txtCA.MaxLength = 100;
            this.txtCA.Name = "txtCA";
            this.txtCA.Size = new System.Drawing.Size(71, 13);
            this.txtCA.TabIndex = 40;
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCA);
            this.Controls.Add(this.btnturma);
            this.Controls.Add(this.cbTurma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbIntegral);
            this.Controls.Add(this.btnDes);
            this.Controls.Add(this.mask);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.data);
            this.Controls.Add(this.txtremedio);
            this.Controls.Add(this.txtclinicos);
            this.Controls.Add(this.txtuf);
            this.Controls.Add(this.txtnat);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtNome);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAluno";
            this.Size = new System.Drawing.Size(383, 366);
            this.Load += new System.EventHandler(this.frmAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMensalidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtnat;
        private System.Windows.Forms.TextBox txtuf;
        private System.Windows.Forms.TextBox txtclinicos;
        private System.Windows.Forms.TextBox txtremedio;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.BindingSource tblMensalidadeBindingSource;
        private DataSource dataSource;
        private DataSourceTableAdapters.tbl_MensalidadeTableAdapter tbl_MensalidadeTableAdapter;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mask;
        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.ComboBox cbIntegral;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cbTurma;
        private System.Windows.Forms.Button btnturma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCA;

    }
}