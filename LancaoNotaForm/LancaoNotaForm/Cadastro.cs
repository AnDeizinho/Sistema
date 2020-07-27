using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LancaoNotaForm
{
    public partial class Cadastro : Form
    {
        DataTable tbl = new DataTable();
        RegrasCad regras;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tornarVisivel()
        {
            pic.Visible = true;
            lbl.Visible = true;
            txtProgramador.Visible = true;
        }
        private void Cadastro_Load(object sender, EventArgs e)
        {
            cbProf.SelectedIndex = 0;
            regras = new RegrasCad(tbl, cbProf);
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            tornarVisivel();
            txtProgramador.Focus();
        }

        private void txtProgramador_Validated(object sender, EventArgs e)
        {
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ComunicaoDeDados dados = new ComunicaoDeDados();
            dados.AtualisaLoginSenhaProfessores(Convert.ToInt32(tbl.Rows[cbProf.SelectedIndex - 1][0].ToString()),txtLogin.Text,txtSenha.Text);
            txtLogin.Clear();
            txtSenha.Clear();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tornarVisivel();
                txtProgramador.Focus();
            }
        }

        private void txtProgramador_TextChanged(object sender, EventArgs e)
        {
            if (txtProgramador.Text == "yerdna15043733")
            {
                btnAtualizar.Enabled = true;
            }
        }

       
    }
}
