using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace SistemaShekinahCompleto.Entidades
{
    public class ProfessorEnt
    {
        public int id_prof {get;set;}
        public string professor { get; set; }
        public string tipo_de_usuario {get;set;}
        public string login {get;set;}
        public string senha { get; set; }
        
        public override string ToString()
        {
            return string.Format("id_prof = {0}\nprofessor = {1}\ntipo_de_usuario = {2}\nlogin = {3}\nsenha = {4}", id_prof, professor, tipo_de_usuario, login, senha);
        }
        
    }

    public class TodasAsProfessoras : List<ProfessorEnt>
    {

    }
    public class AnoEnt
    {
        public int id_Ano {get;set;}
        public string ano {get;set;}
        public Niveis id_nivel { get; set; }
        public override string ToString()
        {
            return string.Format("id_Ano = {0}\nano = {1}\nid_nivel {2}", id_Ano,ano,id_nivel);
        }
        
    }
    public class TodasAsSeries : List<AnoEnt>
    {
        public TodasAsSeries()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from tblano", new SqlConnection(@"Data source = pc-servidor,1433\sqlexpress ; Database = bdatafinalteste ; user id=sa; password = yerdna"));
                cmd.Connection.Open();
                SqlDataReader ler = cmd.ExecuteReader();
                while (ler.Read())
                {
                    this.Add(new AnoEnt { id_Ano = int.Parse(ler["id_ano"].ToString()), 
                        ano = ler["ano"].ToString(), 
                        id_nivel = (Niveis) int.Parse(ler["id_nivel"].ToString()) });
                    
                }
                cmd.Connection.Close();
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
    }
    public enum Turno { Matutino = 1, Vespertino =2 }
    public enum Niveis { Fundamental = 1, Infantil = 2 }
}
