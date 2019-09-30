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
            this.cbTurma = new System.Windows.Forms.ComboBox();
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
            this.txtcodAluno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mask = new System.Windows.Forms.MaskedTextBox();
            this.btnDes = new System.Windows.Forms.Button();
            this.cbIntegral = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblMensalidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(16, 434);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(132, 42);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTurma
            // 
            this.cbTurma.BackColor = System.Drawing.Color.White;
            this.cbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTurma.ForeColor = System.Drawing.Color.Navy;
            this.cbTurma.FormattingEnabled = true;
            this.cbTurma.Items.AddRange(new object[] {
            "SELECIONE"});
            this.cbTurma.Location = new System.Drawing.Point(94, 89);
            this.cbTurma.Name = "cbTurma";
            this.cbTurma.Size = new System.Drawing.Size(187, 30);
            this.cbTurma.TabIndex = 4;
            this.cbTurma.Validated += new System.EventHandler(this.cbTurma_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "Remédios:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Dados Clínicos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "UF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Naturalidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Turma :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Responsável cod:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
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
            this.cb.Location = new System.Drawing.Point(466, 136);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(112, 30);
            this.cb.TabIndex = 8;
            this.cb.Validated += new System.EventHandler(this.cb_Validated);
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
            this.data.Location = new System.Drawing.Point(415, 88);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(163, 31);
            this.data.TabIndex = 5;
            this.data.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtremedio
            // 
            this.txtremedio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtremedio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtremedio.ForeColor = System.Drawing.Color.Navy;
            this.txtremedio.Location = new System.Drawing.Point(16, 345);
            this.txtremedio.MaxLength = 150;
            this.txtremedio.Multiline = true;
            this.txtremedio.Name = "txtremedio";
            this.txtremedio.Size = new System.Drawing.Size(562, 60);
            this.txtremedio.TabIndex = 12;
            // 
            // txtclinicos
            // 
            this.txtclinicos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtclinicos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtclinicos.ForeColor = System.Drawing.Color.Navy;
            this.txtclinicos.Location = new System.Drawing.Point(16, 253);
            this.txtclinicos.MaxLength = 150;
            this.txtclinicos.Multiline = true;
            this.txtclinicos.Name = "txtclinicos";
            this.txtclinicos.Size = new System.Drawing.Size(562, 58);
            this.txtclinicos.TabIndex = 11;
            // 
            // txtuf
            // 
            this.txtuf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtuf.ForeColor = System.Drawing.Color.Navy;
            this.txtuf.Location = new System.Drawing.Point(359, 137);
            this.txtuf.MaxLength = 2;
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(100, 24);
            this.txtuf.TabIndex = 7;
            // 
            // txtnat
            // 
            this.txtnat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnat.ForeColor = System.Drawing.Color.Navy;
            this.txtnat.Location = new System.Drawing.Point(154, 137);
            this.txtnat.MaxLength = 20;
            this.txtnat.Name = "txtnat";
            this.txtnat.Size = new System.Drawing.Size(157, 24);
            this.txtnat.TabIndex = 6;
            // 
            // txtCod
            // 
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.ForeColor = System.Drawing.Color.Navy;
            this.txtCod.Location = new System.Drawing.Point(191, 54);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 24);
            this.txtCod.TabIndex = 2;
            this.txtCod.Validated += new System.EventHandler(this.txtCod_Validated);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.ForeColor = System.Drawing.Color.Navy;
            this.txtNome.Location = new System.Drawing.Point(172, 21);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(406, 24);
            this.txtNome.TabIndex = 1;
            this.txtNome.Validated += new System.EventHandler(this.txtNome_Validated);
            // 
            // tbl_MensalidadeTableAdapter
            // 
            this.tbl_MensalidadeTableAdapter.ClearBeforeFill = true;
            // 
            // txtcodAluno
            // 
            this.txtcodAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcodAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodAluno.ForeColor = System.Drawing.Color.Navy;
            this.txtcodAluno.Location = new System.Drawing.Point(478, 444);
            this.txtcodAluno.Name = "txtcodAluno";
            this.txtcodAluno.Size = new System.Drawing.Size(100, 24);
            this.txtcodAluno.TabIndex = 0;
            this.txtcodAluno.Validated += new System.EventHandler(this.txtcodAluno_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Codigo Aluno";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(356, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 22);
            this.label15.TabIndex = 34;
            this.label15.Text = "Ano :";
            // 
            // txtAno
            // 
            this.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAno.ForeColor = System.Drawing.Color.Navy;
            this.txtAno.Location = new System.Drawing.Point(422, 54);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(156, 24);
            this.txtAno.TabIndex = 3;
            this.txtAno.Text = "2019";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 22);
            this.label10.TabIndex = 36;
            this.label10.Text = "Codigo Do MAC:";
            // 
            // mask
            // 
            this.mask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mask.ForeColor = System.Drawing.Color.Navy;
            this.mask.Location = new System.Drawing.Point(181, 183);
            this.mask.Mask = "000 000 000 000";
            this.mask.Name = "mask";
            this.mask.Size = new System.Drawing.Size(145, 24);
            this.mask.TabIndex = 9;
            // 
            // btnDes
            // 
            this.btnDes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDes.Location = new System.Drawing.Point(159, 434);
            this.btnDes.Name = "btnDes";
            this.btnDes.Size = new System.Drawing.Size(132, 42);
            this.btnDes.TabIndex = 14;
            this.btnDes.Text = "Cancelar";
            this.btnDes.UseVisualStyleBackColor = true;
            this.btnDes.Click += new System.EventHandler(this.btnDes_Click);
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
            this.cbIntegral.Location = new System.Drawing.Point(453, 180);
            this.cbIntegral.Name = "cbIntegral";
            this.cbIntegral.Size = new System.Drawing.Size(125, 30);
            this.cbIntegral.TabIndex = 10;
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 488);
            this.Controls.Add(this.cbIntegral);
            this.Controls.Add(this.btnDes);
            this.Controls.Add(this.mask);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcodAluno);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbTurma);
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
            this.Name = "frmAluno";
            this.Text = "Cadastro do Aluno";
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
        private System.Windows.Forms.ComboBox cbTurma;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.BindingSource tblMensalidadeBindingSource;
        private DataSource dataSource;
        private DataSourceTableAdapters.tbl_MensalidadeTableAdapter tbl_MensalidadeTableAdapter;
        private System.Windows.Forms.TextBox txtcodAluno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mask;
        private System.Windows.Forms.Button btnDes;
        private System.Windows.Forms.ComboBox cbIntegral;

    }
}