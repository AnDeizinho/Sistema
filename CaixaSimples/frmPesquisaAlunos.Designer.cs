namespace CaixaSimples
{
    partial class frmPesquisaAlunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dt = new System.Windows.Forms.DataGridView();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.cb = new System.Windows.Forms.ComboBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.clmIdAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AllowUserToDeleteRows = false;
            this.dt.AllowUserToOrderColumns = true;
            this.dt.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdAluno,
            this.Column1,
            this.nomeAluno,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column2,
            this.Column13});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt.DefaultCellStyle = dataGridViewCellStyle3;
            this.dt.GridColor = System.Drawing.Color.White;
            this.dt.Location = new System.Drawing.Point(12, 97);
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.RowHeadersVisible = false;
            this.dt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt.Size = new System.Drawing.Size(893, 373);
            this.dt.TabIndex = 0;
            this.dt.TabStop = false;
            // 
            // txtnome
            // 
            this.txtnome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.ForeColor = System.Drawing.Color.White;
            this.txtnome.Location = new System.Drawing.Point(104, 50);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(319, 26);
            this.txtnome.TabIndex = 2;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            this.txtnome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_Validating);
            this.txtnome.Validating += new System.ComponentModel.CancelEventHandler(this.txtnome_Validating);
            // 
            // cb
            // 
            this.cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.ForeColor = System.Drawing.Color.White;
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(433, 49);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(186, 28);
            this.cb.TabIndex = 3;
            this.cb.SelectedValueChanged += new System.EventHandler(this.cb_SelectedValueChanged);
            this.cb.Validated += new System.EventHandler(this.cb_Validated);
            // 
            // txtano
            // 
            this.txtano.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtano.ForeColor = System.Drawing.Color.White;
            this.txtano.Location = new System.Drawing.Point(625, 50);
            this.txtano.MaxLength = 4;
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(58, 26);
            this.txtano.TabIndex = 4;
            this.txtano.Text = "2019";
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(686, 53);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(104, 20);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Quantidade : ";
            // 
            // txtCC
            // 
            this.txtCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCC.ForeColor = System.Drawing.Color.White;
            this.txtCC.Location = new System.Drawing.Point(12, 50);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(86, 26);
            this.txtCC.TabIndex = 1;
            this.txtCC.TextChanged += new System.EventHandler(this.txtCC_TextChanged);
            this.txtCC.Validated += new System.EventHandler(this.txtCC_Validated);
            // 
            // clmIdAluno
            // 
            this.clmIdAluno.DataPropertyName = "id_Aluno";
            this.clmIdAluno.HeaderText = "CA";
            this.clmIdAluno.Name = "clmIdAluno";
            this.clmIdAluno.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_Cliente";
            this.Column1.HeaderText = "CC";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // nomeAluno
            // 
            this.nomeAluno.DataPropertyName = "nome";
            this.nomeAluno.HeaderText = "Nome do Aluno";
            this.nomeAluno.MaxInputLength = 100;
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "id_mac";
            this.Column3.HeaderText = "MEC";
            this.Column3.MaxInputLength = 15;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "descricao";
            this.Column4.HeaderText = "Turma";
            this.Column4.MaxInputLength = 20;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "fone_pai";
            this.Column5.HeaderText = "N° do Pai";
            this.Column5.MaxInputLength = 20;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "fone_mae";
            this.Column6.HeaderText = "N° da Mãe";
            this.Column6.MaxInputLength = 20;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "nascimento";
            this.Column7.HeaderText = "Nascimento";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "sexo";
            this.Column8.HeaderText = "Gênero";
            this.Column8.MaxInputLength = 1;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "naturalidade";
            this.Column9.HeaderText = "Naturalidade";
            this.Column9.MaxInputLength = 20;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "uf";
            this.Column10.HeaderText = "UF";
            this.Column10.MaxInputLength = 2;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "dadosClinicos";
            this.Column11.HeaderText = "Dados Clínicos";
            this.Column11.MaxInputLength = 150;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "remedios";
            this.Column12.HeaderText = "Remédios";
            this.Column12.MaxInputLength = 150;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ano_recente";
            this.Column2.HeaderText = "Ano";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "integral";
            this.Column13.HeaderText = "Integral";
            this.Column13.MaxInputLength = 3;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // frmPesquisaAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(917, 482);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.dt);
            this.Name = "frmPesquisaAlunos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretaria";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
    }
}