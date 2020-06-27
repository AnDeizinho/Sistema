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

namespace CaixaSimples
{
    public partial class frmRelatorio : frmFormulario
    {
        DataSet tds = new DataSet();
        int ind = 0;
        public frmRelatorio()
        {
            InitializeComponent();
            
        }
        private void carregaTblMensalidade()
        {
            DataTable tblRMensalidade = new DataTable();
            SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            comando.Parameters.AddWithValue("@data1", StatusDoCaixa.data.Date.AddDays(1));
            comando.CommandText = "SELECT Data, Serie,Aluno, Mes, Forma_Pagamento, Valor FROM tbl_Mensalidade where Data >= @data and Data < @data1";
            comando.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(comando);
            adp.Fill(tblRMensalidade);
            tblRMensalidade.Columns["Serie"].ColumnName = "Série";
            tblRMensalidade.Columns["Mes"].ColumnName = "Mês";
            tblRMensalidade.Columns["Forma_Pagamento"].ColumnName = "Pagamento em";
            
            tds.Tables.Add(tblRMensalidade);
            
            conexao.Close();

        }
        private void carregaTblProduto()
        {
            DataTable tblRProduto = new DataTable();
            SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            comando.Parameters.AddWithValue("@data1", StatusDoCaixa.data.Date.AddDays(1));
            comando.CommandText = "SELECT Data, Valor_Produto, Forma_Pagamento, Descricao FROM tblProdutos where Data >= @data and Data < @data1";
            comando.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(comando);
            adp.Fill(tblRProduto);
            tblRProduto.Columns[1].ColumnName = "Valor";
            tblRProduto.Columns[2].ColumnName = "Pagamento em ";
            tblRProduto.Columns[3].ColumnName = "Descrição";
            tds.Tables.Add(tblRProduto);
            
            conexao.Close();

        }
        private void carregaTblSaida()
        {
            DataTable tblRSaida = new DataTable();
            SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            comando.Parameters.AddWithValue("@data1", StatusDoCaixa.data.Date.AddDays(1));
            comando.CommandText = "SELECT Data, Valor_Saida, Descricao FROM tblSaida where Data >= @data and Data < @data1";
            comando.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(comando);
            adp.Fill(tblRSaida);
            tblRSaida.Columns[1].ColumnName = "Valor";
            tblRSaida.Columns[2].ColumnName = "Descrição";

            tds.Tables.Add(tblRSaida);

            conexao.Close();

        }
        private void carregaTblDeposito()
        {
            DataTable tblRDeposito = new DataTable();
            SqlConnection conexao = new SqlConnection(StatusDoCaixa.conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            comando.Parameters.AddWithValue("@data1", StatusDoCaixa.data.Date.AddDays(1));
            comando.CommandText = "SELECT Data, Valor_Deposito FROM tblDeposito where Data >= @data and Data < @data1";
            comando.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(comando);
            adp.Fill(tblRDeposito);
            tblRDeposito.Columns[1].ColumnName = "Valor de Depósito";
            tds.Tables.Add(tblRDeposito);

            conexao.Close();

        }
        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            carregaTblMensalidade();
            carregaTblProduto();
            
            carregaTblDeposito();
            carregaTblSaida();

            gridBase.DataSource = tds.Tables[0];
            
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            ind += 1;
            if (ind == 1)
            {
                lblTabela.Text = "Produtos";
                gridBase.DataSource = tds.Tables[1];
                gridBase.Refresh();
            }
            else if(ind == 2)
            {
                lblTabela.Text = "Depósito";
                gridBase.DataSource = tds.Tables[2];
                gridBase.Refresh();
            }
            else if (ind == 3)
            {
                lblTabela.Text = "Saída";
                gridBase.DataSource = tds.Tables[3];
                gridBase.Refresh();

            }
            else if (ind > 3)
            {
                ind = 0;

                lblTabela.Text = "Mensalidades";
                gridBase.DataSource = tds.Tables[0];

            }
            
        }

        private void btnImprimi_Click(object sender, EventArgs e)
        {
            imprimi p = new imprimi();
            this.Cursor = Cursors.WaitCursor;
            p.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void gridBase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
