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
    class ComunicaoDeDados
    {
        class totalBimestre
        {
            public totalBimestre(SqlConnection conexao, ref double port,  ref double mat, ref double hist, ref double geog, ref double cien, ref double arte,ref double reli, ref double ingles, ref double fisica, ref int faltas, int idAluno, string ano)
            {
                StringBuilder select = new StringBuilder();
                select.Append(@"SELECT TOP 1000 [id_Bimestre]
      ,[id_aluno]
      ,[ano]
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
  FROM [BDAtaFinal].[dbo].[tbl_Bimestre2] where id_aluno = " + idAluno);
                select.AppendLine("and ano = '"+ ano +"'");
                SqlDataAdapter adp = new SqlDataAdapter(select.ToString(), conexao);
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                port = somaBimestre(Convert.ToDouble(tbl.Rows[0][3].ToString()), Convert.ToDouble(tbl.Rows[1][3].ToString()), Convert.ToDouble(tbl.Rows[2][3].ToString()), Convert.ToDouble(tbl.Rows[3][3].ToString()));
                mat = somaBimestre(Convert.ToDouble(tbl.Rows[0][4].ToString()), Convert.ToDouble(tbl.Rows[1][4].ToString()), Convert.ToDouble(tbl.Rows[2][4].ToString()), Convert.ToDouble(tbl.Rows[3][4].ToString()));
                hist = somaBimestre(Convert.ToDouble(tbl.Rows[0][5].ToString()), Convert.ToDouble(tbl.Rows[1][5].ToString()), Convert.ToDouble(tbl.Rows[2][5].ToString()), Convert.ToDouble(tbl.Rows[3][5].ToString()));
                geog = somaBimestre(Convert.ToDouble(tbl.Rows[0][6].ToString()), Convert.ToDouble(tbl.Rows[1][6].ToString()), Convert.ToDouble(tbl.Rows[2][6].ToString()), Convert.ToDouble(tbl.Rows[3][6].ToString()));
                cien = somaBimestre(Convert.ToDouble(tbl.Rows[0][7].ToString()), Convert.ToDouble(tbl.Rows[1][7].ToString()), Convert.ToDouble(tbl.Rows[2][7].ToString()), Convert.ToDouble(tbl.Rows[3][7].ToString()));
                arte = somaBimestre(Convert.ToDouble(tbl.Rows[0][8].ToString()), Convert.ToDouble(tbl.Rows[1][8].ToString()), Convert.ToDouble(tbl.Rows[2][8].ToString()), Convert.ToDouble(tbl.Rows[3][8].ToString()));
                reli = somaBimestre(Convert.ToDouble(tbl.Rows[0][9].ToString()), Convert.ToDouble(tbl.Rows[1][9].ToString()), Convert.ToDouble(tbl.Rows[2][9].ToString()), Convert.ToDouble(tbl.Rows[3][9].ToString()));
                ingles = somaBimestre(Convert.ToDouble(tbl.Rows[0][10].ToString()), Convert.ToDouble(tbl.Rows[1][10].ToString()), Convert.ToDouble(tbl.Rows[2][10].ToString()), Convert.ToDouble(tbl.Rows[3][10].ToString()));
                fisica = somaBimestre(Convert.ToDouble(tbl.Rows[0][11].ToString()), Convert.ToDouble(tbl.Rows[1][11].ToString()), Convert.ToDouble(tbl.Rows[2][11].ToString()), Convert.ToDouble(tbl.Rows[3][11].ToString()));
                faltas = somaBimestre(Convert.ToInt32(tbl.Rows[0][14].ToString()), Convert.ToInt32(tbl.Rows[1][14].ToString()), Convert.ToInt32(tbl.Rows[2][14].ToString()), Convert.ToInt32(tbl.Rows[3][14].ToString()));

            }
            private double somaBimestre(double b1, double b2,double b3,double b4)
            {
                return b1 + b2 +b3+b4;
            }
            private int somaBimestre(int b1, int b2, int b3, int b4)
            {
                return b1 + b2 + b3 + b4;
            }
        }
        public void updateAta(SqlConnection conexao, double port, double mat, double hist, double geog, double cien, double arte, double reli, double ingles, double fisica, int faltas, int idAluno , string ano)
        {
            totalBimestre tt = new totalBimestre(conexao, ref port,  ref mat, ref hist, ref geog, ref  cien, ref arte,ref  reli, ref  ingles, ref fisica, ref faltas, idAluno, ano);
            

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @"UPDATE [BDAtaFinal].[dbo].[tbl_Notas]
   SET 
      
      [port] = @port
      ,[mat] = @mat
      ,[hist] = @hist
      ,[geog] = @geog
      ,[ciencia] = @ciencia
      ,[arte] = @arte
      ,[religiao] = @religiao
      ,[ingles] = @ingles
      ,[fisica] = @fisica
      
      ,[faltas] = @faltas
 WHERE id_aluno = @id and ano = @ano";
            cmd.Parameters.AddWithValue("@port", port);
            cmd.Parameters.AddWithValue("@mat", mat);
            cmd.Parameters.AddWithValue("@hist", hist);
            cmd.Parameters.AddWithValue("@geog", geog);
            cmd.Parameters.AddWithValue("@ciencia", cien);
            cmd.Parameters.AddWithValue("@arte", arte);
            cmd.Parameters.AddWithValue("@religiao", reli);
            cmd.Parameters.AddWithValue("@ingles", ingles);
            cmd.Parameters.AddWithValue("@fisica", fisica);
            
            cmd.Parameters.AddWithValue("@faltas", faltas);
            cmd.Parameters.AddWithValue("@id", idAluno);
            cmd.Parameters.AddWithValue("@ano", ano);
            conexao.Open();
            cmd.ExecuteNonQuery();
            conexao.Close();
        }
        public void updateNotas(SqlConnection conexao, double port, double mat, double hist, double geog, double cien, double arte, double reli, double ingles, double fisica, string ap, string r, int faltas, int idBimestre)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = @"UPDATE [BDAtaFinal].[dbo].[tbl_Bimestre]
   SET 
      [port] = @port
      ,[mat] = @mat
      ,[hist] = @hist
      ,[geog] = @geog
      ,[ciencia] = @ciencia
      ,[arte] = @arte
      ,[religiao] = @religiao
      ,[ingles] = @ingles
      ,[fisica] = @fisica
      ,[ap] = @ap
      ,[r] = @r
      ,[faltas] = @faltas
      
 WHERE id_bimestre = @idBimestre";
                cmd.Parameters.AddWithValue("@port", port);
                cmd.Parameters.AddWithValue("@mat", mat);
                cmd.Parameters.AddWithValue("@hist", hist);
                cmd.Parameters.AddWithValue("@geog", geog);
                cmd.Parameters.AddWithValue("@ciencia", cien);
                cmd.Parameters.AddWithValue("@arte", arte);
                cmd.Parameters.AddWithValue("@religiao", reli);
                cmd.Parameters.AddWithValue("@ingles", ingles);
                cmd.Parameters.AddWithValue("@fisica", fisica);
                cmd.Parameters.AddWithValue("@ap", ap);
                cmd.Parameters.AddWithValue("@r", r);
                cmd.Parameters.AddWithValue("@faltas", faltas);
                cmd.Parameters.AddWithValue("@idBimestre", idBimestre);
                conexao.Open();
                cmd.ExecuteNonQuery();
                conexao.Close();

                

            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        public void CarregaTabelaProfessores(DataTable tabela, SqlConnection conexao)
        {
            try
            {
                
                SqlDataAdapter adp = new SqlDataAdapter("select id_prof, professor from tbl_professor", conexao);
                adp.Fill(tabela);
                

            }
            catch
            {

            }
        }
        public void AtualisaLoginSenhaProfessores(int id, string login, string senha)
        {
            try
            {
                SqlConnection con = new SqlConnection(DadosStaticos.strCon);
                SqlCommand cmd = new SqlCommand("update tbl_professor set login = '" + login + "' , senha = '" + senha + "' where id_prof = " + id);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Atualizado com Sucesso!!!!");
            }
            catch
            {

            }
        }
    }
}
