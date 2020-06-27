using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace SistemaShekinahCompleto.Entidades
{
    public enum Permissao { Admin, Caixa, Sec }
    public class UserEnt
    {
        public int id { get; private set; }
        public string Usuario { get; private set; }
        public string senha { get; private set; }
        public Permissao Tipo { get; private set; }

        public void setUsuario(string usuario)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection(@"Data Source = PC-SERVIDOR,1433\SqlExpress; DataBase = BDAtaFinalteste; User ID = sa ; Password = yerdna");
            cmd.CommandText = "Select * from tbl_user where usuario = @user";
            cmd.Parameters.AddWithValue("@user", usuario);
            cmd.Connection.Open();
            bool encontrado = false;
            try
            {
                SqlDataReader leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    id = int.Parse(leitor["id_usuario"].ToString());
                    senha = leitor.GetString(2);
                    Tipo = (Permissao)Enum.Parse(typeof(Permissao), leitor["tipo"].ToString());
                    encontrado = true;
                }
                if (encontrado == false)
                    throw new Exception("usuario não encontrado");
                Usuario = usuario;

            }
            catch (SqlException erro)
            {
                Console.WriteLine(erro.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public void setSenha(string bxsenha)
        {
            if (Usuario == "" || Usuario == null)
                throw new ApplicationException("usuário inválido");
            if (this.senha.Contains(bxsenha)!=true)
                throw new ApplicationException("senha inválida");
          
        }
        public override string ToString()
        {
            return "id = " + id + " usuario = " + Usuario + " tipo = " + Tipo;
        }
    }
}
