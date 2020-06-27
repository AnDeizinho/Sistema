using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaShekinahCompleto.Entidades;
using System.Data.SqlClient;
using System.Data;
namespace SistemaShekinahCompleto.Model
{
    public class DbCliente
    {
        Conexao con;
        SqlDataAdapter Adaptador;
        public DbCliente()
        {
            con = new Conexao();
            Adaptador = new SqlDataAdapter("Select * from tbl_cliente", con.NovaConexaoBdAtaFinal());
        }
        public DataTable Select()
        {
            DataTable tbl = new DataTable();
            Adaptador.Fill(tbl);
            return tbl;
        }/*
        public void Seleciona(ClienteEnt cliente , int idDoCliente)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sel_Cliente_proc", con.NovaConexaoBdAtaFinal());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", idDoCliente);
                cmd.Connection.Open();
                SqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    cliente.id_cliente = int.Parse(leitor["id_cliente"].ToString());
                    cliente.pai = leitor["Pai"].ToString();
                    cliente.mae =leitor["mae"].ToString();
                    cliente.cpf_pai=leitor["cpf_pai"].ToString();
                    cliente.cpf_mae=leitor["cpf_mae"].ToString();
                    cliente.fone_pai=leitor["fone_pai"].ToString();
                    cliente.fone_mae=leitor["fone_mae"].ToString();
                    cliente.endereco=leitor["endereco"].ToString();
                    cliente.numero=leitor["numero"].ToString();
                    cliente.bairro=leitor["bairro"].ToString();
                    cliente.complemento=leitor["complemento"].ToString();
                    cliente.cidade=leitor["cidade"].ToString();
                    cliente.estado=leitor["estado"].ToString();
                    cliente.cep=leitor["cep"].ToString();
                    cliente.filhos=int.Parse(leitor["filhos"].ToString());
                    cliente.RG=leitor["RG"].ToString();
                }

                ///////cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                

            }
            catch
            {
                con.NovaConexaoBdAtaFinal().Close();
                

            }


        }*/
        public string Alterar(ClienteEnt cliente)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Up_Cliente_proc", con.NovaConexaoBdAtaFinal());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", cliente.id_cliente);
                cmd.Parameters.AddWithValue("@Pai", cliente.pai);
                cmd.Parameters.AddWithValue("@mae", cliente.mae);
                cmd.Parameters.AddWithValue("@cpf_pai", cliente.cpf_pai);
                cmd.Parameters.AddWithValue("@cpf_mae", cliente.cpf_mae);
                cmd.Parameters.AddWithValue("@fone_pai", cliente.fone_pai);
                cmd.Parameters.AddWithValue("@fone_mae", cliente.fone_mae);
                cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
                cmd.Parameters.AddWithValue("@numero", cliente.numero);
                cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
                cmd.Parameters.AddWithValue("@complemento", cliente.complemento);
                cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
                cmd.Parameters.AddWithValue("@estado", cliente.estado);
                cmd.Parameters.AddWithValue("@cep", cliente.cep);
                cmd.Parameters.AddWithValue("@filhos", cliente.filhos);
                cmd.Parameters.AddWithValue("@RG", cliente.RG);
                cmd.Connection.Open();
              
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
               
                return "Alterado com sucesso \n" + con.mensagens;
               
            }
            catch (Exception erro)
            {
                con.NovaConexaoBdAtaFinal().Close();
                return erro.Message + "\n" + con.mensagens;

            }


        }
        public RetornosDoModel CarregarCliente(ClienteEnt cliente, ref string mensagem)
        {
            try
            {
                DataTable tbl = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter("CarregaUmClientePorId", con.NovaConexaoBdAtaFinal());
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                adaptador.SelectCommand.Parameters.AddWithValue("@id", cliente.id_cliente);
                adaptador.Fill(tbl);
                if (tbl.Rows.Count == 0)
                {
                    mensagem = "Nenhum cliente foi encontrado";
                    cliente.Limpa();
                    return RetornosDoModel.Erro;
                }
                else
                {
                    cliente.pai = tbl.Rows[0]["Pai"].ToString();
                    cliente.mae = tbl.Rows[0]["mae"].ToString();
                    cliente.cpf_pai = tbl.Rows[0]["cpf_pai"].ToString();
                    cliente.cpf_mae = tbl.Rows[0]["cpf_mae"].ToString();
                    cliente.fone_pai = tbl.Rows[0]["fone_pai"].ToString();
                    cliente.fone_mae = tbl.Rows[0]["fone_mae"].ToString();
                    cliente.endereco = tbl.Rows[0]["endereco"].ToString();
                    cliente.numero = tbl.Rows[0]["numero"].ToString();
                    cliente.bairro = tbl.Rows[0]["bairro"].ToString();
                    cliente.complemento = tbl.Rows[0]["complemento"].ToString();
                    cliente.cidade = tbl.Rows[0]["cidade"].ToString();
                    cliente.estado = tbl.Rows[0]["estado"].ToString();
                    cliente.cep = tbl.Rows[0]["cep"].ToString();
                    cliente.filhos = int.Parse(tbl.Rows[0]["filhos"].ToString());
                    cliente.RG = tbl.Rows[0]["RG"].ToString();
                    mensagem = "Cadastrado Com Sucesso";
                    return RetornosDoModel.Cadastrado;
                }
            }
            catch (Exception erro)
            {
                cliente.Limpa();
                mensagem = erro.Message;
                return RetornosDoModel.Erro;

                
            }

        }
        public RetornosDoModel Cadastrar(ClienteEnt cliente)
        {
            try
            {
                   
                   SqlCommand cmd = new SqlCommand("Cad_Cliente_proc", con.NovaConexaoBdAtaFinal());
                  
                   cmd.CommandType = System.Data.CommandType.StoredProcedure;
                   cmd.Parameters.AddWithValue("@Pai", cliente.pai);
                   cmd.Parameters.AddWithValue("@mae", cliente.mae);
                   cmd.Parameters.AddWithValue("@cpf_pai", cliente.cpf_pai);
                   cmd.Parameters.AddWithValue("@cpf_mae", cliente.cpf_mae);
                   cmd.Parameters.AddWithValue("@fone_pai", cliente.fone_pai);
                   cmd.Parameters.AddWithValue("@fone_mae", cliente.fone_mae);
                   cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
                   cmd.Parameters.AddWithValue("@numero", cliente.numero);
                   cmd.Parameters.AddWithValue("@bairro", cliente.bairro);
                   cmd.Parameters.AddWithValue("@complemento", cliente.complemento);
                   cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
                   cmd.Parameters.AddWithValue("@estado", cliente.estado);
                   cmd.Parameters.AddWithValue("@cep", cliente.cep);
                   cmd.Parameters.AddWithValue("@filhos", cliente.filhos);
                   cmd.Parameters.AddWithValue("@RG", cliente.RG);
                   cmd.Connection.Open();
                   int afetadas = 0; 
                   afetadas = cmd.ExecuteNonQuery();
                   cmd.Connection.Close();
                   Adaptador = new SqlDataAdapter("select id_cliente from tbl_cliente where pai = @pai and mae = @mae", con.NovaConexaoBdAtaFinal());
                   Adaptador.SelectCommand.Parameters.AddWithValue("@pai", cliente.pai);
                   Adaptador.SelectCommand.Parameters.AddWithValue("@mae", cliente.mae);
                   DataTable tbl = new DataTable();
                   Adaptador.Fill(tbl);
                   cliente.id_cliente = int.Parse(tbl.Rows[0][0].ToString());
                   Adaptador = null;
                   tbl.Dispose();
                   
                  if (afetadas == 1)
                       return  RetornosDoModel.Cadastrado;
                   else 
                   {
                       return RetornosDoModel.Existe;
                   }
            }
            catch (Exception)
            {
                con.NovaConexaoBdAtaFinal().Close();
                return RetornosDoModel.Erro;
                
            }

            
        }
    }
}
