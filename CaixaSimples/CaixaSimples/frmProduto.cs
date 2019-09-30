using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace CaixaSimples
{
    public partial class frmProduto : frmFormulario
    {
        string valor = "";
        string pg = "";
        string aluno = "";
        string descri = "";

        public frmProduto()
        {
            
            InitializeComponent();
        }

        private void listar()
        {
            SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data);
            comando.Parameters.AddWithValue("@data1", StatusDoCaixa.data.AddDays(1).Date);
            comando.CommandText = @"SELECT Data, Valor_Produto, Aluno, Forma_Pagamento,Descricao FROM tblProdutos where Data >= @data and Data < @data1";
            SqlDataAdapter adp = new SqlDataAdapter(comando);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            grid.DataSource = tbl;
            conexao.Close();
        }
        private void vernder()
        {
            SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute).AddSeconds(DateTime.Now.Second));
            comando.Parameters.AddWithValue("@valor", Convert.ToDouble(Convert.ToDouble(txtValor.Text).ToString("N")));
            comando.Parameters.AddWithValue("@aluno", txtAluno.Text);
            comando.Parameters.AddWithValue("@pg", cbPagamento.Text);
            comando.Parameters.AddWithValue("@desc", txtDescricao.Text);
            comando.CommandText = "insert into tblProdutos (Data, Valor_Produto, Aluno, Forma_Pagamento, Descricao) values (@data, @valor,@aluno, @pg, @desc)";
            comando.ExecuteNonQuery();
            conexao.Close();

        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                vernder();
                valor = Convert.ToDouble(txtValor.Text).ToString("C");
                pg = cbPagamento.Text;
                aluno = txtAluno.Text;
                descri = txtDescricao.Text;

                
                //Dialogo.ShowDialog();
                listar();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Preencha corretamente");
                valor = "";
                txtValor.Text = "";
                pg = "";
                
                aluno = "";
                txtAluno.Text = "";

                descri = "";
                
            }
        }

        private void imprimi_PrintPage(object sender, PrintPageEventArgs e)
        {
            
           
            Font font = new System.Drawing.Font("Arial", 18);
            
            PointF ponto = new PointF(0, 0);
            Brush bru = Brushes.Black;
            string letra = "Teste De impressão \n\t";

            letra += valor + "\n\t";
            letra += pg + "\n\t";
            letra += aluno + "\n\t";
            letra += descri + "\n\t";


            e.Graphics.DrawString(letra, font, bru, ponto);

        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            try
            {
                listar();
            }
            catch
            {
                MessageBox.Show("Erro ao Listar Grid");
            }
        }
    }
}
