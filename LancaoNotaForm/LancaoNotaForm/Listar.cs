using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace LancaoNotaForm
{
    class Listar
    {
        string strCmd = @"SELECT [id_Bimestre]
      ,tbl_Bimestre2.[id_aluno]
      ,tbl_Alunos.nome
      ,tbl_turma.descricao
      ,tbl_Bimestre2.[ano]
      ,[port]
      ,[mat]
      ,[hist]
      ,[geog]
      ,[ciencia]
      ,[arte]
      ,[religiao]
      ,[ingles]
      ,[fisica]
      ,[ap]
      ,[r]
      ,[faltas]
      ,[Bimestre]
        ,Serie
  FROM [tbl_Bimestre2]
  join tbl_Alunos on tbl_Bimestre2.id_aluno = tbl_alunos.id_aluno
  join tbl_turma on tbl_bimestre2.id_turma = tbl_turma.id_turma 
  join tbl_professor on tbl_turma.id_professor = tbl_professor.id_prof
  ";
        string final = "order by descricao, nome";
        public DataTable ListaProf( Professor prof, SqlConnection conexao, DataTable tbl, string ano)
        {

            StringBuilder str = new StringBuilder();
            str.Append(strCmd);
            str.AppendLine("where tbl_Turma.id_professor = ");
            str.Append(prof.getId());
            str.AppendLine(string.Format("and tbl_bimestre2.ano = '{0}'", ano));
            str.AppendLine(final);

            SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
            tbl.Clear();
            tbl = new DataTable();
            adp.Fill(tbl);
            return tbl;

        }
        public DataTable ListaAdm( SqlConnection conexao, DataTable tbl, string ano)
        {
            SqlDataAdapter adp = new SqlDataAdapter(string.Format("{0} \n{1}\n{2}",strCmd, string.Format("where tbl_bimestre2.ano = '{0}'",ano), final), conexao);
            tbl.Clear();
            adp.Fill(tbl);
            
            return tbl;
        }
        /// <summary>
        ///  bimestre
        /// </summary>
        /// <param name="conexao">conexao do sql</param>
        /// <param name="tbl">a tabela</param>
        /// <param name="idProf">id do professor</param>
        /// <param name="bimestre">qual o bimestre</param>
        /// <param name="tipo">tipo de permição</param>
        /// <returns>a tabela preenchida</returns>
        public DataTable ListaComParametros( SqlConnection conexao, DataTable tbl, int idProf, int bimestre, string tipo, string ano)
        {
            if (tipo.Contains("adm") == true) 
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine("where bimestre = " + bimestre + " and tbl_bimestre2.ano = '"+ ano+"'");
                
                //str.Append(bimestre);
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;
            }

            else if (tipo.Contains("prof") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine("where tbl_Turma.id_Professor = " + idProf);
                //str.Append(idProf);
                str.AppendLine("and bimestre = " + bimestre + string.Format(" and tbl_bimestre2.ano = '{0}'", ano));
                //str.Append(bimestre);
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;
                
            }
            else if (tipo.Contains("ingles") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine("where bimestre = " + bimestre + string.Format(" and tbl_bimestre2.ano = '{0}'", ano));

                //str.Append(bimestre);
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;
                
            }
            return tbl;
        }
        
        /// <summary>
        /// select do bimestre + turma
        /// </summary>
        
        public DataTable ListaComParametros(SqlConnection conexao, DataTable tbl, int idProf, int bimestre, string tipo, int id_turma, string ano)
        {
            if (tipo.Contains("adm") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine(string.Format("where bimestre = {0} and tbl_bimestre2.ano = '{1}'",  bimestre, ano));

                //str.Append(bimestre);
                str.AppendLine("and tbl_bimestre2.id_turma = " + id_turma);
                //str.Append(id_turma);
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;

            }

            else if (tipo.Contains("prof") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine("where tbl_Turma.id_Professor = " + idProf);
                //str.Append(idProf);
                str.AppendLine("and bimestre = " + bimestre);
                //str.Append(bimestre);
                str.AppendLine(string.Format("and tbl_bimestre2.id_turma = {0} and tbl_bimestre2.ano = {1} " , id_turma, ano));
                //str.Append(id_turma);
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;

            }
            else if (tipo.Contains("ingles") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine("where bimestre = " + bimestre);

                //str.Append(bimestre);
                str.AppendLine(string.Format("and tbl_bimestre2.id_turma = {0} and tbl_bimestre2.ano = {1}" , id_turma, ano));
                //str.Append(id_turma);
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;

            }
            return tbl;
        }
        //
        /// <summary>
        /// select somente turma
        /// </summary>
        /// <param name="conexao"></param>
        /// <param name="tbl"></param>
        /// <param name="idProf"></param>
        /// <param name="tipo"></param>
        /// <param name="id_turma"></param>
        /// <returns></returns>
        public DataTable ListaComParametros(SqlConnection conexao, DataTable tbl, int idProf, string tipo, int id_turma,string ano)
        {
            if (tipo.Contains("adm") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                
                str.AppendLine(string.Format("where tbl_bimestre2.id_turma = {0} and tbl_bimestre2.ano = '{1}'" , id_turma , ano));
                //str.Append(id_turma);
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;
            }

            else if (tipo.Contains("prof") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine(string.Format("where tbl_Turma.id_Professor = {0} and tbl_Bimestre2.ano = '{1}'" , idProf, ano));
                //str.Append(idProf);
                
                str.AppendLine("and tbl_bimestre2.id_turma = " + id_turma);
                //str.Append(id_turma);
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;
            }
            else if (tipo.Contains("ingles") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                
                str.AppendLine("where tbl_bimestre.id_turma = " + id_turma + string.Format(" and tbl_bimestre2.ano = '{1}'", ano));
                //str.Append(id_turma);
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;
            }
            return tbl;
        }
        
        //
        /// <summary>
        /// select somente aluno
        /// </summary>
        /// <param name="conexao"></param>
        /// <param name="tbl"></param>
        /// <param name="idProf"></param>
        /// <param name="tipo"></param>
        /// <param name="aluno"></param>
        /// <returns></returns>
        public DataTable ListaComParametros(SqlConnection conexao, DataTable tbl, int idProf, string tipo, string aluno, string ano)
        {
            if (tipo.Contains("adm") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);

                str.AppendLine(string.Format("where nome like '%{0}%' and tbl_bimestre2.ano = '{1}'", aluno, ano));
                //str.Append(aluno);
                //str.Append("%'");
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;
            }

            else if (tipo.Contains("prof") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine("where tbl_Turma.id_Professor = " + idProf);
                //str.Append(idProf);

                str.AppendLine(string.Format("and nome like '%{0}%' and tbl_bimestre2.ano = '{1}'", aluno, ano));
                //str.Append(aluno);
                //str.Append("%'");
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;

            }
            else if (tipo.Contains("ingles") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);

                str.AppendLine("where nome like '%" + aluno + "%'" + string.Format(" and tbl_bimestre2.ano = '{0}'", ano));
                //str.Append(aluno);
                //str.Append("%'");
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;
            }
            return tbl;
        }
        
        /// <summary>
        /// bimestre + aluno
        /// </summary>
        ///
        /// <returns></returns>
        public DataTable ListaComParametros(SqlConnection conexao, DataTable tbl, int idProf, int bimestre, string tipo, string aluno,string ano)
        {
            if (tipo.Contains("adm") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine("where bimestre = " + bimestre + " ");


                str.AppendLine(string.Format("and tbl_bimestre2.ano = '{0}' ", ano));

                str.AppendLine("and tbl_alunos.nome like '%" + aluno + "%'");

                str.AppendLine(final);
                //MessageBox.Show(str.ToString());
                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;

            }

            else if (tipo.Contains("prof") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine("where tbl_Turma.id_Professor = " + idProf);
                //str.Append(idProf);
                str.AppendLine("and bimestre = " + bimestre);
                //str.Append(bimestre);
                //str.AppendLine("and tbl_turma.id_turma = " + id_turma);
                //str.Append(id_turma);
                str.AppendLine("and tbl_alunos.nome like '%" + aluno + "%'");
                str.AppendLine(string.Format("and tbl_bimestre2.ano = '{0}'", ano));
                //str.Append("%'");
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;

            }
            else if (tipo.Contains("ingles") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine("where bimestre = " + bimestre);

                //str.Append(bimestre);
                //str.AppendLine("and tbl_turma.id_turma = " + id_turma);
                //str.Append(id_turma);
                str.AppendLine("and tbl_alunos.nome like '%" + aluno + "%'");
                //str.Append(aluno);
                //str.Append("%'");
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;

            }
            return tbl;
        }
        /// turma + aluno
        /// <summary>
        /// turma + aluno
        /// </summary>
        /// 
        /// 
        /// <returns></returns>
        public DataTable ListaComParametros(SqlConnection conexao, DataTable tbl, int idProf, string tipo, int id_turma, string aluno,string ano)
        {
            if (tipo.Contains("adm") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                //str.AppendLine("where bimestre = " + bimestre + " ");


                str.AppendLine("where tbl_bimestre2.id_turma = " + id_turma);

                str.AppendLine("and tbl_alunos.nome like '%" + aluno + "%'");
                str.AppendLine(string.Format("and tbl_bimestre2.ano ='{0}'", ano));

                str.AppendLine(final);
                //MessageBox.Show(str.ToString());
                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;

            }

            else if (tipo.Contains("prof") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine("where tbl_Turma.id_Professor = " + idProf);
                //str.Append(idProf);
                //str.AppendLine("and bimestre = " + bimestre);
                //str.Append(bimestre);
                str.AppendLine("and tbl_bimestre2.id_turma = " + id_turma);
                //str.Append(id_turma);
                str.AppendLine("and tbl_alunos.nome like '%" + aluno + "%'");
                str.AppendLine(string.Format("and tbl_bimestre2.ano = '{0}'", ano));
                //str.Append("%'");
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;

            }
            else if (tipo.Contains("ingles") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                //str.AppendLine("where bimestre = " + bimestre);

                //str.Append(bimestre);
                str.AppendLine("where tbl_bimestre2.id_turma = " + id_turma);
                //str.Append(id_turma);
                str.AppendLine("and tbl_alunos.nome like '%" + aluno + "%'");
                str.AppendLine(string.Format("and tbl_bimestre2.ano = '{0}'", ano));
                //str.Append("%'");
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;

            }
            return tbl;
        }
        /// <summary>
        /// select turma + aluno + bimestre
        /// </summary>
        /// <param name="conexao"></param>
        /// <param name="tbl"></param>
        /// <param name="idProf"></param>
        /// <param name="bimestre"></param>
        /// <param name="tipo"></param>
        /// <param name="id_turma"></param>
        /// <returns></returns>
        public DataTable ListaComParametros(SqlConnection conexao, DataTable tbl, int idProf, int bimestre, string tipo, int id_turma,string aluno, string ano)
        {
            if (tipo.Contains("adm") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine("where bimestre = " + bimestre + " ");

                
                str.AppendLine("and tbl_bimestre2.id_turma = " + id_turma);
                
                str.AppendLine("and tbl_alunos.nome like '%" + aluno + "%'");

                str.AppendLine(string.Format("and tbl_bimestre2.ano = '{0}'",ano));
                
                str.AppendLine(final);
                //MessageBox.Show(str.ToString());
                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;

            }

            else if (tipo.Contains("prof") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine("where tbl_Turma.id_Professor = " + idProf);
                //str.Append(idProf);
                str.AppendLine("and bimestre = " + bimestre);
                //str.Append(bimestre);
                str.AppendLine("and tbl_bimestre2.id_turma = " + id_turma);
                //str.Append(id_turma);
                str.AppendLine("and tbl_alunos.nome like '%" + aluno + "%'");
                //str.Append(aluno);
                str.AppendLine(string.Format("and tbl_bimestre2.ano = '{0}'", ano));
                //str.Append("%'");
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;

            }
            else if (tipo.Contains("ingles") == true)
            {
                StringBuilder str = new StringBuilder();
                str.Append(strCmd);
                str.AppendLine("where bimestre = " + bimestre);

                //str.Append(bimestre);
                str.AppendLine("and tbl_bimestre2.id_turma = " + id_turma);
                //str.Append(id_turma);
                str.AppendLine("and tbl_alunos.nome like '%" + aluno + "%'");
                //str.Append(aluno);
                //str.Append("%'");
                str.AppendLine(string.Format("and tbl_bimestre2.ano = '{0}'", ano));
                str.AppendLine(final);

                tbl.Clear();
                SqlDataAdapter adp = new SqlDataAdapter(str.ToString(), conexao);
                adp.Fill(tbl);
                return tbl;

            }
            return tbl;
        }
        


        
    }
}
