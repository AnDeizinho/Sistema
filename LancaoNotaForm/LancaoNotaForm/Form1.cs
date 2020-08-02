using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LancaoNotaForm
{
    public partial class Form1 : Form
    {
        DataTable tbl = new DataTable();
        Professor prof = new Professor();
        public Form1()
        {
            InitializeComponent();
            
        }
        public object retornaProfessor()
        {
            return prof;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            validaSenha();

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao = new SqlConnection(DadosStaticos.strCon);
                SqlDataAdapter adp = new SqlDataAdapter("select  login from tbl_professor where login = '" + txtLogin.Text +"'", conexao);
                adp.Fill(tbl);
                if (tbl.Rows.Count == 0)
                {
                    
                    txtLogin.Clear();

                    return;

                }
                prof.Login = txtLogin.Text;


            }
            catch
            {
                MessageBox.Show("erro na comunicação com o servidor");

            }
        }

        private void validaSenha()
        {
            prof.Senha = txtSenha.Text;
            switch (prof.carrega())
            {
                case 0:
                    
                    txtSenha.Clear();
                    break;
                case 1:
                    MessageBox.Show("Seja bem vinda " + prof.Login);
                    this.Close();
                    break;
                case 2:
                    MessageBox.Show("Existe mai de um usuario com este login e senha\n contate o analista para resolver este problema");
                    txtSenha.Clear();
                    txtLogin.Clear();
                    break;
                case 3:
                    MessageBox.Show("Erro No Comando");
                    txtSenha.Clear();
                    txtLogin.Clear();
                    break;

                    
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.ShowDialog();
        }
    }
}
