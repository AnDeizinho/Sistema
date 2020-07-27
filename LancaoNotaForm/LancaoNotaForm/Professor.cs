using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace LancaoNotaForm
{
    class Professor
    {
         int Id ; 
         string Nome ;
        string Tipo;
        public string Login;
        public  string Senha;
        SqlConnection conexao = new SqlConnection(DadosStaticos.strCon);

        public Professor()
        {
            
        }
        public int carrega()
        {
            try
            {
                
                SqlDataAdapter adp = new SqlDataAdapter("select id_prof, professor, tipo_de_usuario, login, senha from tbl_professor where login = '" + Login + "' and senha = '" + Senha + "'", conexao);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                if (tbl.Rows.Count == 0)
                {
                    return 0;
                }
                else if (tbl.Rows.Count == 1)
                {
                    Id = Convert.ToInt32(tbl.Rows[0][0].ToString());
                    Nome = tbl.Rows[0][1].ToString();
                    Tipo = tbl.Rows[0][2].ToString();

                    return 1;
                }
                else
                {
                    return 2;
                }
                
                
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
                return 3;
            }

        }
        public int getId()
        {
            return Id;
        }
        public string getNome()
        {
            return Nome;
        }
        public string getTipo()
        {
            return Tipo;
        }
        
    }
}
