namespace CaixaSimples
{
    partial class frmCad_Cliente
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
            this.cbMesParcela = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtParcela = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnAluno = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnConc = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtFoneMae = new System.Windows.Forms.MaskedTextBox();
            this.txtFonePai = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfMae = new System.Windows.Forms.MaskedTextBox();
            this.txtCpfPai = new System.Windows.Forms.MaskedTextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.txtNomePai = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbMesParcela
            // 
            this.cbMesParcela.BackColor = System.Drawing.Color.White;
            this.cbMesParcela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMesParcela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMesParcela.ForeColor = System.Drawing.Color.Navy;
            this.cbMesParcela.FormattingEnabled = true;
            this.cbMesParcela.Items.AddRange(new object[] {
            "<mes>",
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
            this.cbMesParcela.Location = new System.Drawing.Point(460, 401);
            this.cbMesParcela.Name = "cbMesParcela";
            this.cbMesParcela.Size = new System.Drawing.Size(143, 30);
            this.cbMesParcela.TabIndex = 17;
            this.cbMesParcela.SelectedIndexChanged += new System.EventHandler(this.cbMesParcela_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(349, 404);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 22);
            this.label17.TabIndex = 36;
            this.label17.Text = "Apartir de:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 404);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 22);
            this.label16.TabIndex = 34;
            this.label16.Text = "Valor da Parcela:";
            // 
            // txtParcela
            // 
            this.txtParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtParcela.ForeColor = System.Drawing.Color.Navy;
            this.txtParcela.Location = new System.Drawing.Point(186, 401);
            this.txtParcela.MaxLength = 150;
            this.txtParcela.Name = "txtParcela";
            this.txtParcela.Size = new System.Drawing.Size(153, 31);
            this.txtParcela.TabIndex = 16;
            this.txtParcela.Validated += new System.EventHandler(this.textBox1_Validated_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(398, 357);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 22);
            this.label15.TabIndex = 32;
            this.label15.Text = "Ano :";
            // 
            // txtAno
            // 
            this.txtAno.ForeColor = System.Drawing.Color.Navy;
            this.txtAno.Location = new System.Drawing.Point(464, 354);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(139, 31);
            this.txtAno.TabIndex = 15;
            this.txtAno.Text = "2019";
            // 
            // btnAluno
            // 
            this.btnAluno.Enabled = false;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Location = new System.Drawing.Point(413, 448);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(192, 31);
            this.btnAluno.TabIndex = 19;
            this.btnAluno.Text = "Adicionar Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(310, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "Pesquisar Codigo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConc
            // 
            this.btnConc.Enabled = false;
            this.btnConc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConc.Location = new System.Drawing.Point(211, 448);
            this.btnConc.Name = "btnConc";
            this.btnConc.Size = new System.Drawing.Size(192, 31);
            this.btnConc.TabIndex = 18;
            this.btnConc.Text = "Concluir";
            this.btnConc.UseVisualStyleBackColor = true;
            this.btnConc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 22);
            this.label14.TabIndex = 27;
            this.label14.Text = "Codigo do Cliente :";
            // 
            // txtCod
            // 
            this.txtCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCod.ForeColor = System.Drawing.Color.Navy;
            this.txtCod.Location = new System.Drawing.Point(206, 20);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(89, 31);
            this.txtCod.TabIndex = 1;
            this.txtCod.Text = "0";
            this.txtCod.Validated += new System.EventHandler(this.txtCod_Validated);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(215, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 22);
            this.label13.TabIndex = 25;
            this.label13.Text = "CEP:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 22);
            this.label12.TabIndex = 24;
            this.label12.Text = "Estado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 22);
            this.label11.TabIndex = 23;
            this.label11.Text = "Cidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 22);
            this.label10.TabIndex = 22;
            this.label10.Text = "Complemento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 22);
            this.label9.TabIndex = 21;
            this.label9.Text = "Bairro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "N°:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 19;
            this.label7.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fone Mãe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fone Pai:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "CPF da Mãe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "CPF do Pai:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome da Mãe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome do Pai:";
            // 
            // txtCep
            // 
            this.txtCep.ForeColor = System.Drawing.Color.Navy;
            this.txtCep.Location = new System.Drawing.Point(273, 354);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(105, 31);
            this.txtCep.TabIndex = 14;
            // 
            // txtFoneMae
            // 
            this.txtFoneMae.ForeColor = System.Drawing.Color.Navy;
            this.txtFoneMae.Location = new System.Drawing.Point(419, 187);
            this.txtFoneMae.Mask = "(00)00000-0000";
            this.txtFoneMae.Name = "txtFoneMae";
            this.txtFoneMae.Size = new System.Drawing.Size(186, 31);
            this.txtFoneMae.TabIndex = 7;
            // 
            // txtFonePai
            // 
            this.txtFonePai.ForeColor = System.Drawing.Color.Navy;
            this.txtFonePai.Location = new System.Drawing.Point(404, 145);
            this.txtFonePai.Mask = "(00)00000-0000";
            this.txtFonePai.Name = "txtFonePai";
            this.txtFonePai.Size = new System.Drawing.Size(201, 31);
            this.txtFonePai.TabIndex = 5;
            // 
            // txtCpfMae
            // 
            this.txtCpfMae.ForeColor = System.Drawing.Color.Navy;
            this.txtCpfMae.Location = new System.Drawing.Point(146, 187);
            this.txtCpfMae.Mask = "000 000 000-00";
            this.txtCpfMae.Name = "txtCpfMae";
            this.txtCpfMae.Size = new System.Drawing.Size(150, 31);
            this.txtCpfMae.TabIndex = 6;
            // 
            // txtCpfPai
            // 
            this.txtCpfPai.ForeColor = System.Drawing.Color.Navy;
            this.txtCpfPai.Location = new System.Drawing.Point(130, 145);
            this.txtCpfPai.Mask = "000 000 000-00";
            this.txtCpfPai.Name = "txtCpfPai";
            this.txtCpfPai.Size = new System.Drawing.Size(165, 31);
            this.txtCpfPai.TabIndex = 4;
            this.txtCpfPai.Validated += new System.EventHandler(this.txtCpfPai_Validated);
            // 
            // txtEstado
            // 
            this.txtEstado.AutoCompleteCustomSource.AddRange(new string[] {
            "AM"});
            this.txtEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.ForeColor = System.Drawing.Color.Navy;
            this.txtEstado.Location = new System.Drawing.Point(98, 354);
            this.txtEstado.MaxLength = 2;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(102, 31);
            this.txtEstado.TabIndex = 13;
            // 
            // txtCidade
            // 
            this.txtCidade.AutoCompleteCustomSource.AddRange(new string[] {
            "MANAUS"});
            this.txtCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.ForeColor = System.Drawing.Color.Navy;
            this.txtCidade.Location = new System.Drawing.Point(419, 271);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(186, 31);
            this.txtCidade.TabIndex = 11;
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.ForeColor = System.Drawing.Color.Navy;
            this.txtComplemento.Location = new System.Drawing.Point(166, 313);
            this.txtComplemento.MaxLength = 150;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(437, 31);
            this.txtComplemento.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.ForeColor = System.Drawing.Color.Navy;
            this.txtBairro.Location = new System.Drawing.Point(84, 271);
            this.txtBairro.MaxLength = 150;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(243, 31);
            this.txtBairro.TabIndex = 10;
            // 
            // txtNumero
            // 
            this.txtNumero.ForeColor = System.Drawing.Color.Navy;
            this.txtNumero.Location = new System.Drawing.Point(505, 229);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 31);
            this.txtNumero.TabIndex = 9;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.ForeColor = System.Drawing.Color.Navy;
            this.txtEndereco.Location = new System.Drawing.Point(122, 229);
            this.txtEndereco.MaxLength = 150;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(339, 31);
            this.txtEndereco.TabIndex = 8;
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeMae.ForeColor = System.Drawing.Color.Navy;
            this.txtNomeMae.Location = new System.Drawing.Point(166, 103);
            this.txtNomeMae.MaxLength = 100;
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(439, 31);
            this.txtNomeMae.TabIndex = 3;
            this.txtNomeMae.Leave += new System.EventHandler(this.txtNomeMae_Leave);
            this.txtNomeMae.Validated += new System.EventHandler(this.txtNomeMae_Validated);
            // 
            // txtNomePai
            // 
            this.txtNomePai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomePai.ForeColor = System.Drawing.Color.Navy;
            this.txtNomePai.Location = new System.Drawing.Point(150, 61);
            this.txtNomePai.MaxLength = 100;
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Size = new System.Drawing.Size(455, 31);
            this.txtNomePai.TabIndex = 2;
            this.txtNomePai.Validated += new System.EventHandler(this.txtNomePai_Validated);
            // 
            // frmCad_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 495);
            this.Controls.Add(this.cbMesParcela);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtParcela);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtFoneMae);
            this.Controls.Add(this.txtFonePai);
            this.Controls.Add(this.txtCpfMae);
            this.Controls.Add(this.txtCpfPai);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNomeMae);
            this.Controls.Add(this.txtNomePai);
            this.Name = "frmCad_Cliente";
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.frmCad_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomePai;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.MaskedTextBox txtCpfPai;
        private System.Windows.Forms.MaskedTextBox txtCpfMae;
        private System.Windows.Forms.MaskedTextBox txtFonePai;
        private System.Windows.Forms.MaskedTextBox txtFoneMae;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btnConc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtParcela;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbMesParcela;
    }
}