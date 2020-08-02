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
//            SqlDataAdapter adp = new SqlDataAdapter(@"SELECT TOP (1000) 
//      a.[id_aluno],
//	  b.id_turma,
//	  b.ano_recente
//	  ,c.id_ano
//      
//  FROM [BDAtaFinal].[dbo].[tbl_Bimestre] a
//  join tbl_Alunos b on a.id_aluno = b.id_aluno
//	join tbl_turma c on b.id_turma = c.id_turma
//  where ano_recente = '2020' and a.ano = 2019
//  group by a.id_aluno, b.id_turma, b.ano_recente, c.id_ano", new Conexao().NovaConexaoBdAtaFinal());
//            DataTable tbl = new DataTable();
//            adp.Fill(tbl);
//            DbAlunos db = new DbAlunos();
//            foreach (DataRow i in tbl.Rows)
//            {
//                AlunoEnt al = new AlunoEnt();
//                al.id_aluno = int.Parse(i[0].ToString());
//                al.turma.id_turma = int.Parse(i[1].ToString());
//                al.ano_recente = i[2].ToString().Trim();
//                al.turma.Ano.id_Ano = int.Parse(i[3].ToString());
//                Console.WriteLine(al);
//                try{
//                db.RenovarMatricula(new AtaFinalEnt(al, new GetSerie(al.turma.Ano.id_Ano).Serie));
//                }catch(Exception erro)
//                {
//                    Console.WriteLine(erro.Message);
//                    Console.ReadKey();
//                }
//            }
//            Console.ReadKey();
            
            
        }
    }
}
