using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SistemaShekinahCompleto.Model;
namespace CaixaSimples
{
    
    
        public class adp
        {
            SqlConnection conexao = new Conexao().NovaConexaoBdAtaFinal();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            SqlCommand cmd;
            public adp(string select)
            {
                //adaptador.DeleteCommand.Connection = conexao;
                //adaptador.UpdateCommand.Connection = conexao;
                //adaptador.InsertCommand.Connection = conexao;

                cmd = new SqlCommand(select, conexao);
                //adaptador.SelectCommand.Connection = conexao;
                adaptador.SelectCommand = cmd;
            }
            public void deleteComando(SqlCommand comando)
            {
                try
                {
                    //adaptador.DeleteCommand.Connection = conexao;
                    //adaptador.UpdateCommand.Connection = conexao;
                    comando.Connection = conexao;
                    conexao.Open();
                    adaptador.DeleteCommand = comando;
                    adaptador.DeleteCommand.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("erro no update" + erro.ToString());
                }
            }
            public void UpdateComando(SqlCommand comando)
            {
                try
                {
                    //adaptador.DeleteCommand.Connection = conexao;
                    //adaptador.UpdateCommand.Connection = conexao;
                    comando.Connection = conexao;
                    conexao.Open();
                    adaptador.UpdateCommand = comando;
                    adaptador.UpdateCommand.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("erro no update" + erro.ToString());
                }
            }
            public void Preencher(DataTable tbl)
            {
                try
                {
                    adaptador.Fill(tbl);
                }
                catch
                {
                    MessageBox.Show("erro ao preencher");
                }
            }
            public void SelectComando(SqlCommand comando)
            {
                try
                {

                    comando.Connection = conexao;
                    conexao.Open();
                    adaptador.SelectCommand = comando;
                    adaptador.SelectCommand.ExecuteNonQuery();
                    conexao.Close();
                }
                catch
                {
                    MessageBox.Show("falha no comando select");
                }

            }
            public void InsertComando(SqlCommand comando)
            {
                try
                {

                    //adaptador.DeleteCommand.Connection = conexao;
                    //adaptador.UpdateCommand.Connection = conexao;
                    //adaptador.InsertCommand.Connection = conexao;
                    comando.Connection = conexao;
                    conexao.Open();
                    adaptador.InsertCommand = comando;

                    adaptador.InsertCommand.ExecuteNonQuery();
                    conexao.Close();
                }
                catch (Exception ERRO)
                {
                    MessageBox.Show("erro no comando inserir\n\n" + ERRO.ToString());
                }
            }


        }
    
}
