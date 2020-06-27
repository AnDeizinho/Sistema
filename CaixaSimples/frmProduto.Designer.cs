namespace CaixaSimples
{
    partial class frmProduto
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.Dialogo = new System.Windows.Forms.PrintPreviewDialog();
            this.imprimi = new System.Drawing.Printing.PrintDocument();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPagamento = new System.Windows.Forms.ComboBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.grid = new CaixaSimples.DataGridBase();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Dialogo
            // 
            this.Dialogo.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.Dialogo.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.Dialogo.ClientSize = new System.Drawing.Size(400, 300);
            this.Dialogo.Document = this.imprimi;
            this.Dialogo.Enabled = true;
            this.Dialogo.Icon = ((System.Drawing.Icon)(resources.GetObject("Dialogo.Icon")));
            this.Dialogo.Name = "Dialogo";
            this.Dialogo.Visible = false;
            // 
            // imprimi
            // 
            this.imprimi.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.imprimi_PrintPage);
            // 
            // txtAluno
            // 
            this.txtAluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAluno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAluno.ForeColor = System.Drawing.Color.Navy;
            this.txtAluno.Location = new System.Drawing.Point(99, 82);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(260, 24);
            this.txtAluno.TabIndex = 3;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(12, 82);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(81, 22);
            this.lblAluno.TabIndex = 11;
            this.lblAluno.Text = "Alunos :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pagamento :";
            // 
            // cbPagamento
            // 
            this.cbPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPagamento.ForeColor = System.Drawing.Color.Navy;
            this.cbPagamento.FormattingEnabled = true;
            this.cbPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Crédito"});
            this.cbPagamento.Location = new System.Drawing.Point(148, 45);
            this.cbPagamento.Name = "cbPagamento";
            this.cbPagamento.Size = new System.Drawing.Size(211, 30);
            this.cbPagamento.TabIndex = 2;
            // 
            // btnVender
            // 
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Location = new System.Drawing.Point(365, 15);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(144, 91);
            this.btnVender.TabIndex = 5;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.Navy;
            this.txtDescricao.Location = new System.Drawing.Point(12, 112);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(497, 43);
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.Text = "Descrição :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor :";
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.ForeColor = System.Drawing.Color.Navy;
            this.txtValor.Location = new System.Drawing.Point(86, 15);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(273, 24);
            this.txtValor.TabIndex = 1;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 161);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.Size = new System.Drawing.Size(497, 161);
            this.grid.TabIndex = 6;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 334);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPagamento);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.grid);
            this.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.Name = "frmProduto";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnVender;
        private DataGridBase grid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPagamento;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.PrintPreviewDialog Dialogo;
        private System.Drawing.Printing.PrintDocument imprimi;

    }
}