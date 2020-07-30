namespace LancaoNotaForm
{
    partial class frmMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.cbTurmas = new System.Windows.Forms.ComboBox();
            this.txtAluno = new System.Windows.Forms.TextBox();
            this.cbbimestre = new System.Windows.Forms.ComboBox();
            this.lblProf = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Tfalt = new System.Windows.Forms.TextBox();
            this.Tfis = new System.Windows.Forms.TextBox();
            this.Ting = new System.Windows.Forms.TextBox();
            this.Trel = new System.Windows.Forms.TextBox();
            this.Tart = new System.Windows.Forms.TextBox();
            this.Tcie = new System.Windows.Forms.TextBox();
            this.Tgeog = new System.Windows.Forms.TextBox();
            this.Thist = new System.Windows.Forms.TextBox();
            this.Tmat = new System.Windows.Forms.TextBox();
            this.Tport = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dt = new System.Windows.Forms.DataGridView();
            this.Bimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_bimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.religiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faltas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtano = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.txtano);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.cbTurmas);
            this.panel1.Controls.Add(this.txtAluno);
            this.panel1.Controls.Add(this.cbbimestre);
            this.panel1.Controls.Add(this.lblProf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 120);
            this.panel1.TabIndex = 0;
            //this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(855, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 36);
            this.button4.TabIndex = 16;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbTurmas
            // 
            this.cbTurmas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTurmas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurmas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurmas.ForeColor = System.Drawing.Color.Blue;
            this.cbTurmas.FormattingEnabled = true;
            this.cbTurmas.Items.AddRange(new object[] {
            "Turma"});
            this.cbTurmas.Location = new System.Drawing.Point(317, 55);
            this.cbTurmas.Name = "cbTurmas";
            this.cbTurmas.Size = new System.Drawing.Size(206, 33);
            this.cbTurmas.TabIndex = 3;
            this.cbTurmas.SelectedIndexChanged += new System.EventHandler(this.cbTurmas_SelectedIndexChanged);
            // 
            // txtAluno
            // 
            this.txtAluno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluno.ForeColor = System.Drawing.Color.Blue;
            this.txtAluno.Location = new System.Drawing.Point(529, 55);
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.Size = new System.Drawing.Size(299, 31);
            this.txtAluno.TabIndex = 2;
            this.txtAluno.TextChanged += new System.EventHandler(this.txtAluno_TextChanged);
            // 
            // cbbimestre
            // 
            this.cbbimestre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbimestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbimestre.ForeColor = System.Drawing.Color.Blue;
            this.cbbimestre.FormattingEnabled = true;
            this.cbbimestre.Items.AddRange(new object[] {
            "Bimestre",
            "1° Bimestre",
            "2° Bimestre",
            "3° Bimestre",
            "4° Bimestre"});
            this.cbbimestre.Location = new System.Drawing.Point(156, 55);
            this.cbbimestre.Name = "cbbimestre";
            this.cbbimestre.Size = new System.Drawing.Size(152, 33);
            this.cbbimestre.TabIndex = 1;
            this.cbbimestre.SelectedIndexChanged += new System.EventHandler(this.cbbimestre_SelectedIndexChanged);
            // 
            // lblProf
            // 
            this.lblProf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProf.Location = new System.Drawing.Point(104, 13);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(58, 25);
            this.lblProf.TabIndex = 0;
            this.lblProf.Text = "Prof :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Tfalt);
            this.panel2.Controls.Add(this.Tfis);
            this.panel2.Controls.Add(this.Ting);
            this.panel2.Controls.Add(this.Trel);
            this.panel2.Controls.Add(this.Tart);
            this.panel2.Controls.Add(this.Tcie);
            this.panel2.Controls.Add(this.Tgeog);
            this.panel2.Controls.Add(this.Thist);
            this.panel2.Controls.Add(this.Tmat);
            this.panel2.Controls.Add(this.Tport);
            this.panel2.Controls.Add(this.lblAluno);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 198);
            this.panel2.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(817, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Faltas:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(729, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Física:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(641, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Inglês:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(553, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Religião:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(465, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Arte:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(377, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ciência:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(289, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Geografia:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(201, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "História:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(113, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Matemática:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(25, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Português:";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(524, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 36);
            this.button3.TabIndex = 15;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(356, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(415, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Lançar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tfalt
            // 
            this.Tfalt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Tfalt.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tfalt.Location = new System.Drawing.Point(817, 62);
            this.Tfalt.Name = "Tfalt";
            this.Tfalt.Size = new System.Drawing.Size(62, 36);
            this.Tfalt.TabIndex = 12;
            this.Tfalt.TextChanged += new System.EventHandler(this.Tfalt_TextChanged);
            // 
            // Tfis
            // 
            this.Tfis.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Tfis.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tfis.Location = new System.Drawing.Point(729, 62);
            this.Tfis.Name = "Tfis";
            this.Tfis.Size = new System.Drawing.Size(62, 36);
            this.Tfis.TabIndex = 11;
            this.Tfis.TextChanged += new System.EventHandler(this.Tfis_TextChanged);
            this.Tfis.Validated += new System.EventHandler(this.Tfis_Validated);
            // 
            // Ting
            // 
            this.Ting.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Ting.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ting.Location = new System.Drawing.Point(641, 62);
            this.Ting.Name = "Ting";
            this.Ting.Size = new System.Drawing.Size(62, 36);
            this.Ting.TabIndex = 10;
            this.Ting.TextChanged += new System.EventHandler(this.Ting_TextChanged);
            this.Ting.Validated += new System.EventHandler(this.Ting_Validated);
            // 
            // Trel
            // 
            this.Trel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Trel.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trel.Location = new System.Drawing.Point(553, 62);
            this.Trel.Name = "Trel";
            this.Trel.Size = new System.Drawing.Size(62, 36);
            this.Trel.TabIndex = 9;
            this.Trel.TextChanged += new System.EventHandler(this.Trel_TextChanged);
            this.Trel.Validated += new System.EventHandler(this.Trel_Validated);
            // 
            // Tart
            // 
            this.Tart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Tart.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tart.Location = new System.Drawing.Point(465, 62);
            this.Tart.Name = "Tart";
            this.Tart.Size = new System.Drawing.Size(62, 36);
            this.Tart.TabIndex = 8;
            this.Tart.TextChanged += new System.EventHandler(this.Tart_TextChanged);
            this.Tart.Validated += new System.EventHandler(this.Tart_Validated);
            // 
            // Tcie
            // 
            this.Tcie.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Tcie.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tcie.Location = new System.Drawing.Point(377, 62);
            this.Tcie.Name = "Tcie";
            this.Tcie.Size = new System.Drawing.Size(62, 36);
            this.Tcie.TabIndex = 7;
            this.Tcie.TextChanged += new System.EventHandler(this.Tcie_TextChanged);
            this.Tcie.Validated += new System.EventHandler(this.Tcie_Validated);
            // 
            // Tgeog
            // 
            this.Tgeog.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Tgeog.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tgeog.Location = new System.Drawing.Point(289, 62);
            this.Tgeog.Name = "Tgeog";
            this.Tgeog.Size = new System.Drawing.Size(62, 36);
            this.Tgeog.TabIndex = 6;
            this.Tgeog.TextChanged += new System.EventHandler(this.Tgeog_TextChanged);
            this.Tgeog.Validated += new System.EventHandler(this.Tgeog_Validated);
            // 
            // Thist
            // 
            this.Thist.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Thist.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thist.Location = new System.Drawing.Point(201, 62);
            this.Thist.Name = "Thist";
            this.Thist.Size = new System.Drawing.Size(62, 36);
            this.Thist.TabIndex = 5;
            this.Thist.TextChanged += new System.EventHandler(this.Thist_TextChanged);
            this.Thist.Validated += new System.EventHandler(this.Thist_Validated);
            // 
            // Tmat
            // 
            this.Tmat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Tmat.BackColor = System.Drawing.Color.White;
            this.Tmat.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tmat.Location = new System.Drawing.Point(113, 62);
            this.Tmat.Name = "Tmat";
            this.Tmat.Size = new System.Drawing.Size(62, 36);
            this.Tmat.TabIndex = 4;
            this.Tmat.TextChanged += new System.EventHandler(this.Tmat_TextChanged);
            this.Tmat.Validated += new System.EventHandler(this.Tmat_Validated);
            // 
            // Tport
            // 
            this.Tport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Tport.BackColor = System.Drawing.Color.White;
            this.Tport.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tport.Location = new System.Drawing.Point(25, 62);
            this.Tport.Name = "Tport";
            this.Tport.Size = new System.Drawing.Size(62, 36);
            this.Tport.TabIndex = 3;
            this.Tport.TextChanged += new System.EventHandler(this.Tport_TextChanged);
            this.Tport.Validated += new System.EventHandler(this.Tport_Validated);
            // 
            // lblAluno
            // 
            this.lblAluno.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.ForeColor = System.Drawing.Color.Blue;
            this.lblAluno.Location = new System.Drawing.Point(40, 24);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(105, 23);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Aluno(a) :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 162);
            this.panel3.TabIndex = 3;
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AllowUserToDeleteRows = false;
            this.dt.AllowUserToResizeRows = false;
            this.dt.BackgroundColor = System.Drawing.Color.White;
            this.dt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bimestre,
            this.id_aluno,
            this.Nome,
            this.Column2,
            this.id_bimestre,
            this.ano,
            this.port,
            this.mat,
            this.hist,
            this.geog,
            this.ciencia,
            this.arte,
            this.religiao,
            this.ingles,
            this.fisica,
            this.ap,
            this.rep,
            this.faltas});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dt.EnableHeadersVisualStyles = false;
            this.dt.GridColor = System.Drawing.Color.Blue;
            this.dt.Location = new System.Drawing.Point(0, 0);
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.RowHeadersVisible = false;
            this.dt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt.Size = new System.Drawing.Size(910, 162);
            this.dt.TabIndex = 2;
            this.dt.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_RowEnter);
            // 
            // Bimestre
            // 
            this.Bimestre.DataPropertyName = "bimestre";
            this.Bimestre.HeaderText = "Bimestre";
            this.Bimestre.Name = "Bimestre";
            this.Bimestre.ReadOnly = true;
            this.Bimestre.Width = 50;
            // 
            // id_aluno
            // 
            this.id_aluno.DataPropertyName = "id_Aluno";
            this.id_aluno.HeaderText = "CA";
            this.id_aluno.Name = "id_aluno";
            this.id_aluno.ReadOnly = true;
            this.id_aluno.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Aluno";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 250;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "descricao";
            this.Column2.HeaderText = "Turma";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // id_bimestre
            // 
            this.id_bimestre.DataPropertyName = "id_Bimestre";
            this.id_bimestre.HeaderText = "Cod Bim";
            this.id_bimestre.Name = "id_bimestre";
            this.id_bimestre.ReadOnly = true;
            this.id_bimestre.Visible = false;
            // 
            // ano
            // 
            this.ano.DataPropertyName = "ano";
            this.ano.HeaderText = "Ano";
            this.ano.Name = "ano";
            this.ano.ReadOnly = true;
            this.ano.Width = 50;
            // 
            // port
            // 
            this.port.DataPropertyName = "port";
            this.port.HeaderText = "Portug";
            this.port.Name = "port";
            this.port.ReadOnly = true;
            this.port.Width = 50;
            // 
            // mat
            // 
            this.mat.DataPropertyName = "mat";
            this.mat.HeaderText = "Matem";
            this.mat.Name = "mat";
            this.mat.ReadOnly = true;
            this.mat.Width = 50;
            // 
            // hist
            // 
            this.hist.DataPropertyName = "hist";
            this.hist.HeaderText = "Hist";
            this.hist.Name = "hist";
            this.hist.ReadOnly = true;
            this.hist.Width = 50;
            // 
            // geog
            // 
            this.geog.DataPropertyName = "geog";
            this.geog.HeaderText = "Geog";
            this.geog.Name = "geog";
            this.geog.ReadOnly = true;
            this.geog.Width = 50;
            // 
            // ciencia
            // 
            this.ciencia.DataPropertyName = "ciencia";
            this.ciencia.HeaderText = "Ciência";
            this.ciencia.Name = "ciencia";
            this.ciencia.ReadOnly = true;
            this.ciencia.Width = 50;
            // 
            // arte
            // 
            this.arte.DataPropertyName = "arte";
            this.arte.HeaderText = "Arte";
            this.arte.Name = "arte";
            this.arte.ReadOnly = true;
            this.arte.Width = 50;
            // 
            // religiao
            // 
            this.religiao.DataPropertyName = "religiao";
            this.religiao.HeaderText = "Religião";
            this.religiao.Name = "religiao";
            this.religiao.ReadOnly = true;
            this.religiao.Width = 50;
            // 
            // ingles
            // 
            this.ingles.DataPropertyName = "ingles";
            this.ingles.HeaderText = "Inglês";
            this.ingles.Name = "ingles";
            this.ingles.ReadOnly = true;
            this.ingles.Width = 50;
            // 
            // fisica
            // 
            this.fisica.DataPropertyName = "fisica";
            this.fisica.HeaderText = "Física";
            this.fisica.Name = "fisica";
            this.fisica.ReadOnly = true;
            this.fisica.Width = 50;
            // 
            // ap
            // 
            this.ap.DataPropertyName = "ap";
            this.ap.HeaderText = "Aprovado";
            this.ap.Name = "ap";
            this.ap.ReadOnly = true;
            // 
            // rep
            // 
            this.rep.DataPropertyName = "r";
            this.rep.HeaderText = "Reprovado";
            this.rep.Name = "rep";
            this.rep.ReadOnly = true;
            // 
            // faltas
            // 
            this.faltas.DataPropertyName = "faltas";
            this.faltas.HeaderText = "Faltas";
            this.faltas.Name = "faltas";
            this.faltas.ReadOnly = true;
            // 
            // txtano
            // 
            this.txtano.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtano.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtano.ForeColor = System.Drawing.Color.Blue;
            this.txtano.Location = new System.Drawing.Point(23, 55);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(125, 31);
            this.txtano.TabIndex = 17;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAluno;
        private System.Windows.Forms.ComboBox cbbimestre;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tfalt;
        private System.Windows.Forms.TextBox Tfis;
        private System.Windows.Forms.TextBox Ting;
        private System.Windows.Forms.TextBox Trel;
        private System.Windows.Forms.TextBox Tart;
        private System.Windows.Forms.TextBox Tcie;
        private System.Windows.Forms.TextBox Tgeog;
        private System.Windows.Forms.TextBox Thist;
        private System.Windows.Forms.TextBox Tmat;
        private System.Windows.Forms.TextBox Tport;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.ComboBox cbTurmas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_bimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn port;
        private System.Windows.Forms.DataGridViewTextBoxColumn mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn hist;
        private System.Windows.Forms.DataGridViewTextBoxColumn geog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn arte;
        private System.Windows.Forms.DataGridViewTextBoxColumn religiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingles;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ap;
        private System.Windows.Forms.DataGridViewTextBoxColumn rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn faltas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtano;
    }
}