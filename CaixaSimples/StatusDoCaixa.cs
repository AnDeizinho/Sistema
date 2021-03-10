using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaShekinahCompleto.Model;
namespace CaixaSimples
{
    public static class StatusDoCaixa
    {
        public static string vardata, vardinheiro, varsaida, vardebito, varcredito, varcartao, varentrada, varproduto, varespecie, varcaixa, vardeposito, varapresentado, varconclusao;
        public static string comandoResumo = "select Data, Status, Dinheiro, Saida, Credito, Total_Cartao, Total_Entrada, Total_Produtos, Total_Especie, Fundo_De_Caixa, Total_Deposito, Valor_Apresentado from tblResumo_De_Caixas where Data >= '" + StatusDoCaixa.data.Date.ToString() + "' and Data < '" + StatusDoCaixa.data.Date.AddDays(1).ToString() + "'";
        public static int idCaixa = 0;
        public static DateTime data = DateTime.Now.Date;
        public static char status = 'f';
        public static double dinheiro = 0;
        public static double saida = 0;
        public static double debito = 0;
        public static double credito = 0;
        public static double ttcartao = 0;
        public static double ttentrada = 0;
        public static double ttprodutos = 0;
        public static double ttespecie = 0;
        public static double fdCaixa = 0;
        public static double ttDeposito = 0;
        public static double valoApresentado = 0;
        public static double conclusao = 0;
        
        public static string conStringBDCaixa = @"Data Source = Nilza\SqlExpress; DataBase = BDCaixa ; User ID = sa ; Password = yerdna";
        public static string conStringBDAtaFinal = @"Data Source = Nilza\SqlExpress; DataBase = BDAtaFinal ; User ID = sa ; Password = yerdna";
        public static void CalculaDinheiro()
        {
            SqlConnection conexao = new SqlConnection(conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            comando.Parameters.AddWithValue("@outro", StatusDoCaixa.data.Date.AddDays(1));
             
            comando.CommandText = "select Valor from tbl_Mensalidade where Data >= @data and Data < @outro and Forma_Pagamento = 'Dinheiro'";
            comando.ExecuteNonQuery();

            //SqlConnection conexao = new SqlConnection(@"Data Source = ACER\SQLEXPRESS; DataBase = BDcaixa; Trusted_Connection = true");
            
            SqlCommand comando1 = new SqlCommand();
            comando1.Connection = conexao;
            comando1.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            comando1.Parameters.AddWithValue("@outro", StatusDoCaixa.data.Date.AddDays(1));

            comando1.CommandText = "select Valor_Produto from tblProdutos where Data >= @data and Data < @outro and Forma_Pagamento = 'Dinheiro'";
            comando1.ExecuteNonQuery();

            SqlDataAdapter adp = new SqlDataAdapter(comando);
            DataTable tbl_mensalidade = new DataTable();
            adp.Fill(tbl_mensalidade);
            double totalMensalidade = 0;
            foreach (DataRow linha in tbl_mensalidade.Rows)
            {
                totalMensalidade += Convert.ToDouble(linha[0].ToString());

            }

            SqlDataAdapter adp1 = new SqlDataAdapter(comando1);
            DataTable tblProduto = new DataTable();
            adp1.Fill(tblProduto);
            double totalProduto = 0;
            foreach (DataRow linha in tblProduto.Rows)
            {
                totalProduto += Convert.ToDouble(linha[0].ToString());

            }
            
            SqlCommand atualizaMensalidade = new SqlCommand();

            atualizaMensalidade.Connection = conexao;
            atualizaMensalidade.Parameters.AddWithValue("@totalmes", totalMensalidade + totalProduto);
            atualizaMensalidade.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            atualizaMensalidade.CommandText = "update tblResumo_De_Caixas set Dinheiro = @totalmes where Data = @data";
            atualizaMensalidade.ExecuteNonQuery();

            conexao.Close();
        }
        public static void calculaSaida()
        {
            SqlConnection conexao = new SqlConnection(conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            comando.Parameters.AddWithValue("@outro", StatusDoCaixa.data.Date.AddDays(1));

            comando.CommandText = "select Valor_Saida from tblSaida where Data >= @data and Data < @outro ";
            comando.ExecuteNonQuery();

            SqlDataAdapter adp = new SqlDataAdapter(comando);
            DataTable tblSaida = new DataTable();
            adp.Fill(tblSaida);
            double totalSaida = 0;
            foreach (DataRow linha in tblSaida.Rows)
            {
                totalSaida += Convert.ToDouble(linha[0].ToString());

            }

            SqlCommand atualizaSaida = new SqlCommand();

            atualizaSaida.Connection = conexao;
            atualizaSaida.Parameters.AddWithValue("@totalSaida", totalSaida);
            atualizaSaida.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            atualizaSaida.CommandText = "update tblResumo_De_Caixas set Saida = @totalSaida where Data = @data";
            atualizaSaida.ExecuteNonQuery();

            conexao.Close();
        }
        public static void calculaDebito()
        {
            double totalMensalidade = 0;
            double totalProduto = 0;
            SqlConnection conexao = new SqlConnection(conStringBDCaixa);
            conexao.Open();
            SqlCommand cmdMensalidade = new SqlCommand();
            cmdMensalidade.Connection = conexao;
            cmdMensalidade.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            cmdMensalidade.Parameters.AddWithValue("@outro", StatusDoCaixa.data.Date.AddDays(1));

            cmdMensalidade.CommandText = "select Valor from tbl_Mensalidade where Data >= @data and Data < @outro and Forma_Pagamento = 'Débito'";
            cmdMensalidade.ExecuteNonQuery();

            SqlCommand cmdProduto = new SqlCommand();
            cmdProduto.Connection = conexao;
            cmdProduto.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            cmdProduto.Parameters.AddWithValue("@outro", StatusDoCaixa.data.Date.AddDays(1));

            cmdProduto.CommandText = "select Valor_Produto from tblProdutos where Data >= @data and Data < @outro and Forma_Pagamento = 'Débito'";
            cmdProduto.ExecuteNonQuery();

            SqlDataAdapter adp = new SqlDataAdapter(cmdMensalidade);
            DataTable tbl_mensalidade = new DataTable();
            adp.Fill(tbl_mensalidade);
            
            foreach (DataRow linha in tbl_mensalidade.Rows)
            {
                totalMensalidade += Convert.ToDouble(linha[0].ToString());

            }
            SqlDataAdapter adp2 = new SqlDataAdapter(cmdProduto);
            DataTable tblProduto = new DataTable();
            adp2.Fill(tblProduto);
            
            foreach (DataRow linha in tblProduto.Rows)
            {
                totalProduto += Convert.ToDouble(linha[0].ToString());

            }

            SqlCommand atualizaMensalidade = new SqlCommand();
            double total = totalMensalidade + totalProduto;
            atualizaMensalidade.Connection = conexao;
            atualizaMensalidade.Parameters.AddWithValue("@totalmes", total);
            atualizaMensalidade.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            atualizaMensalidade.CommandText = "update tblResumo_De_Caixas set Debito = @totalmes where Data = @data";
            atualizaMensalidade.ExecuteNonQuery();

            conexao.Close();
        }
        public static void calculaTotalDeposito()
        {
            SqlConnection conexao = new SqlConnection(conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            comando.Parameters.AddWithValue("@outro", StatusDoCaixa.data.Date.AddDays(1));

            comando.CommandText = "select Valor_Deposito from tblDeposito where Data >= @data and Data < @outro ";
            comando.ExecuteNonQuery();

            SqlDataAdapter adp = new SqlDataAdapter(comando);
            DataTable tblDeposito = new DataTable();
            adp.Fill(tblDeposito);
            double totalDeposito = 0;
            foreach (DataRow linha in tblDeposito.Rows)
            {
                totalDeposito += Convert.ToDouble(linha[0].ToString());

            }

            SqlCommand atualizaDeposito = new SqlCommand();

            atualizaDeposito.Connection = conexao;
            atualizaDeposito.Parameters.AddWithValue("@totaldeposito", totalDeposito);
            atualizaDeposito.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            atualizaDeposito.CommandText = "update tblResumo_De_Caixas set Total_Deposito = @totaldeposito where Data = @data";
            atualizaDeposito.ExecuteNonQuery();

            conexao.Close();
        }
        public static void calculaCredito()
        {
            SqlConnection conexao = new SqlConnection(conStringBDCaixa);
            conexao.Open();
            SqlCommand cmdMensalidade = new SqlCommand();
            cmdMensalidade.Connection = conexao;
            cmdMensalidade.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            cmdMensalidade.Parameters.AddWithValue("@outro", StatusDoCaixa.data.Date.AddDays(1));

            cmdMensalidade.CommandText = "select Valor from tbl_Mensalidade where Data >= @data and Data < @outro and Forma_Pagamento = 'Crédito'";
            cmdMensalidade.ExecuteNonQuery();

            SqlCommand cmdProduto = new SqlCommand();
            cmdProduto.Connection = conexao;
            cmdProduto.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            cmdProduto.Parameters.AddWithValue("@outro", StatusDoCaixa.data.Date.AddDays(1));

            cmdProduto.CommandText = "select Valor_Produto from tblProdutos where Data >= @data and Data < @outro and Forma_Pagamento = 'Crédito'";
            cmdProduto.ExecuteNonQuery();

            SqlDataAdapter adpMes = new SqlDataAdapter(cmdMensalidade);
            DataTable tbl_mensalidade = new DataTable();
            adpMes.Fill(tbl_mensalidade);
            double totalMensalidade = 0;
            foreach (DataRow linha in tbl_mensalidade.Rows)
            {
                totalMensalidade += Convert.ToDouble(linha[0].ToString());

            }

            SqlDataAdapter adpProd = new SqlDataAdapter(cmdProduto);
            DataTable tblProduto = new DataTable();
            adpProd.Fill(tblProduto);
            double totalProduto = 0;
            foreach (DataRow linha in tblProduto.Rows)
            {
                totalProduto += Convert.ToDouble(linha[0].ToString());

            }

            SqlCommand atualizaMensalidade = new SqlCommand();

            atualizaMensalidade.Connection = conexao;
            atualizaMensalidade.Parameters.AddWithValue("@totalmes", totalMensalidade + totalProduto);
            atualizaMensalidade.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            atualizaMensalidade.CommandText = "update tblResumo_De_Caixas set Credito = @totalmes where Data = @data";
            atualizaMensalidade.ExecuteNonQuery();

            conexao.Close();
        }
        public static void calculaTotalCartao()
        {
            SqlConnection conexao = new SqlConnection(conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            comando.CommandText = "update tblResumo_De_Caixas set Total_Cartao = Credito + Debito where Data = @data";
            comando.ExecuteNonQuery();
            conexao.Close();

        }
        public static void calculaTotalEntrada()
        {
            SqlConnection conexao = new SqlConnection(conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            comando.CommandText = "update tblResumo_De_Caixas set Total_Entrada = Credito + Debito + Dinheiro where Data = @data";
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public static void calculaTotalProduto()
        {
            SqlConnection conexao = new SqlConnection(conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            comando.Parameters.AddWithValue("@outro", StatusDoCaixa.data.Date.AddDays(1));

            comando.CommandText = "select Valor_Produto from tblProdutos where Data >= @data and Data < @outro ";
            comando.ExecuteNonQuery();

            SqlDataAdapter adp = new SqlDataAdapter(comando);
            DataTable tblProduto = new DataTable();
            adp.Fill(tblProduto);
            double totalProduto = 0;
            foreach (DataRow linha in tblProduto.Rows)
            {
                totalProduto += Convert.ToDouble(linha[0].ToString());

            }

            SqlCommand atualizaMensalidade = new SqlCommand();

            atualizaMensalidade.Connection = conexao;
            atualizaMensalidade.Parameters.AddWithValue("@totalProd", totalProduto);
            atualizaMensalidade.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            atualizaMensalidade.CommandText = "update tblResumo_De_Caixas set Total_Produtos = @totalProd where Data = @data";
            atualizaMensalidade.ExecuteNonQuery();

            conexao.Close();
        }
        public static void calculaEspecie()
        {
            SqlConnection conexao = new SqlConnection(conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            comando.CommandText = "update tblResumo_De_Caixas set Total_Especie = Dinheiro - Saida where Data = @data";
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public static void calculaConclusao()
        {
            SqlConnection conexao = new SqlConnection(conStringBDCaixa);
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.Parameters.AddWithValue("@data", StatusDoCaixa.data.Date);
            comando.CommandText = "update tblResumo_De_Caixas set Conclusao = (Total_Deposito + Valor_Apresentado - Fundo_De_Caixa) - Total_Especie where Data = @data";
            comando.ExecuteNonQuery();
            conexao.Close();
        }
        public static void Calculos()
        {
            StatusDoCaixa.CalculaDinheiro();
            StatusDoCaixa.calculaSaida();
            StatusDoCaixa.calculaDebito();
            StatusDoCaixa.calculaTotalDeposito();
            StatusDoCaixa.calculaCredito();
            StatusDoCaixa.calculaTotalCartao();
            StatusDoCaixa.calculaTotalEntrada();
            StatusDoCaixa.calculaTotalProduto();
            StatusDoCaixa.calculaEspecie();
            StatusDoCaixa.calculaConclusao();
        }


    }
}
