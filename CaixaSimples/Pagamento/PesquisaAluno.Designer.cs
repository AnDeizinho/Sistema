namespace CaixaSimples.Pagamento
{
    partial class PesquisaAluno
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
            this.gp_psq = new System.Windows.Forms.GroupBox();
            this.lbalunos = new System.Windows.Forms.DataGridView();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.gp_psq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbalunos)).BeginInit();
            this.SuspendLayout();
            // 
            // gp_psq
            // 
            this.gp_psq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_psq.Controls.Add(this.lbalunos);
            this.gp_psq.Controls.Add(this.txtAluno);
            this.gp_psq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gp_psq.Location = new System.Drawing.Point(14, 13);
            this.gp_psq.Margin = new System.Windows.Forms.Padding(20);
            this.gp_psq.Name = "gp_psq";
            this.gp_psq.Size = new System.Drawing.Size(713, 312);
            this.gp_psq.TabIndex = 4;
            this.gp_psq.TabStop = false;
            this.gp_psq.Text = "Pesquisar aluno";
            // 
            // lbalunos
            // 
            this.lbalunos.AllowUserToAddRows = false;
            this.lbalunos.AllowUserToDeleteRows = false;
            this.lbalunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbalunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lbalunos.Location = new System.Drawing.Point(9, 58);
            this.lbalunos.Name = "lbalunos";
            this.lbalunos.ReadOnly = true;
            this.lbalunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lbalunos.Size = new System.Drawing.Size(688, 224);
            this.lbalunos.TabIndex = 1;
            this.lbalunos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lbalunos_CellDoubleClick);
            // 
            // txtAluno
            // 
            this.txtAluno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAluno.Location = new System.Drawing.Point(9, 32);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(688, 20);
            this.txtAluno.TabIndex = 0;
            this.txtAluno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAluno_KeyDown);
            // 
            // PesquisaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 307);
            this.Controls.Add(this.gp_psq);
            this.Name = "PesquisaAluno";
            
            this.gp_psq.ResumeLayout(false);
            this.gp_psq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbalunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_psq;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.DataGridView lbalunos;
    }
}
