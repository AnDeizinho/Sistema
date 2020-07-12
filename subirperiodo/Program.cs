using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaShekinahCompleto.Model;
using SistemaShekinahCompleto.Entidades;
namespace subirperiodo
{
    public static class Extensoes
    {
        public static AlunoEnt ParaAluno(this SqlDataReader l)
        {
            AlunoEnt aluno = new AlunoEnt();
            aluno.id_aluno = int.Parse(l["id_aluno"].ToString());
            aluno.nome = l["nome"].ToString().Trim();
            aluno.id_cliente = int.Parse(l["id_Cliente"].ToString());
            aluno.ano_recente = l["ano_recente"].ToString().Trim();
            aluno.turma.id_turma = int.Parse(l["id_turma"].ToString());
            aluno.nascimento = DateTime.Parse(l["nascimento"].ToString()).Date;
            aluno.sexo = l["sexo"].ToString().Trim();
            aluno.naturalidade = l["naturalidade"].ToString().Trim();
            aluno.uf = l["uf"].ToString().Trim();
            aluno.dadosClinicos = l["dadosClinicos"].ToString().Trim();
            aluno.remedios = l["remedios"].ToString().Trim();
            aluno.id_mac = l["id_mac"].ToString().Trim();
            aluno.integral = l["integral"].ToString().Trim();
  
            return aluno;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
//            SqlDataAdapter adp = new SqlDataAdapter(@"SELECT TOP (1000) [id_aluno]
//      ,[nome]
//      ,[id_cliente]
//      ,[ano_recente]
//      ,a.[id_turma]
//	  ,descricao
//      ,[nascimento]
//      ,[sexo]
//      ,[naturalidade]
//      ,[uf]
//      ,[dadosClinicos]
//      ,[remedios]
//      ,[id_mac]
//      ,[integral]
//  FROM [BDAtaFinal].[dbo].[tbl_Alunos] as a join tbl_turma as b on a.id_turma = b.id_turma
//  where id_aluno in (69, 77, 93, 98, 106, 109 ,144 ,157 , 158, 223,230,231,263,268,290,297,322,327,353,
// 368,303,306,226,228,24,32,42,222,115 ) order by a.id_turma", new Conexao().NovaConexaoBdAtaFinal());
//            AlunosEnt aluno = new AlunosEnt();
//            adp.SelectCommand.Connection.Open();
//            SqlDataReader leitor =  adp.SelectCommand.ExecuteReader();
//            while(leitor.Read())
//            {
//                aluno.Add(leitor.ParaAluno());
//            }
//            adp.SelectCommand.Connection.Close();
//            Console.WriteLine(aluno.Count.ToString());
//            DbAlunos al = new DbAlunos();
//            foreach (AlunoEnt i in aluno)
//            {
//                if (i.turma.id_turma == 19)
//                    i.turma.id_turma = 1;
//                else if (i.turma.id_turma == 20)
//                    i.turma.id_turma = 2;
//                i.ano_recente = "2020";
//                al.AtualizaAlunos(i);
//                Console.WriteLine(i);
//            }
            
//            Console.ReadKey();
            
            
        }
    }
}
