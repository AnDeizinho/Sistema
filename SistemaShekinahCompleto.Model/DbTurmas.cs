using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;   
using SistemaShekinahCompleto.Entidades;
namespace SistemaShekinahCompleto.Model
{
    public class DbTurmas
    {
        
        Conexao com = new Conexao();
        public RetornosDoModel AtualizaTurmas(TurmaEnt turma, out string mensagem)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"if(select COUNT(0) from tbl_turma where id_turno = @id_turno
                                                and id_professor = @id_professor and ano = @ano) > 0
                                                print ('turma já cadastrada')
                                                else
                                                            update [tbl_turma] set 
                                                           [id_ano]=@id_ano
                                                           ,[id_turno]=@id_turno
                                                           ,[id_professor]=@id_professor
                                                           ,[descricao]=@descricao
                                                           ,[ano]=@ano
                                                     
                                                           where id_turma = @id", new Conexao().NovaConexaoBdAtaFinal());
                cmd.Parameters.AddWithValue("@id", turma.id_turma);
                cmd.Parameters.AddWithValue("@id_ano", turma.Ano.id_Ano);
                cmd.Parameters.AddWithValue("@id_turno", turma.Turnos);
                cmd.Parameters.AddWithValue("@id_professor", turma.Professeor.id_prof);
                cmd.Parameters.AddWithValue("@descricao", turma.descricao);

                cmd.Parameters.AddWithValue("@ano", turma.ano);
                cmd.Connection.Open();
                int ENQ = cmd.ExecuteNonQuery();

                cmd.Connection.Close();

                if (ENQ == -1)
                {
                    mensagem = string.Format("A professora {0} \njá da aula no turno {1}, \nna turma {2}", turma.Professeor.professor, turma.Turnos, turma.descricao);
                    return RetornosDoModel.Existe;
                }
                mensagem = string.Format("A professora {0} \nfoi cadastrado com êxito, na turma {1}", turma.Professeor.professor, turma.descricao);
                return RetornosDoModel.Cadastrado;
            }
            catch (Exception erro)
            {

                mensagem = erro.Message;
                return RetornosDoModel.Erro;
            }
                
        }
        public RetornosDoModel  CadastraTurmas(TurmaEnt turma, out string mensagem)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"if(select COUNT(0) from tbl_turma where id_turno = @id_turno
                                                and id_professor = @id_professor and ano = @ano) > 0
                                                print ('turma já cadastrada')
                                                else


                                                INSERT INTO [tbl_turma]
                                                           ([id_ano]
                                                           ,[id_turno]
                                                           ,[id_professor]
                                                           ,[descricao]
                                                           ,[ano])
                                                     VALUES
                                                           (@id_ano
                                                           ,@id_turno
                                                           ,@id_professor
                                                           ,@descricao
                                                           ,@ano)", new Conexao().NovaConexaoBdAtaFinal());
                cmd.Parameters.AddWithValue("@id_ano", turma.Ano.id_Ano);
                cmd.Parameters.AddWithValue("@id_turno", turma.Turnos);
                cmd.Parameters.AddWithValue("@id_professor", turma.Professeor.id_prof);
                cmd.Parameters.AddWithValue("@descricao", turma.descricao);
                
                cmd.Parameters.AddWithValue("@ano", turma.ano);
                cmd.Connection.Open();
                int ENQ = cmd.ExecuteNonQuery();
                    
                cmd.Connection.Close();
                
                if (ENQ == -1)
                {
                    mensagem = string.Format("A professora {0}\n já da aula no turno {1}, \npor isso não foi possível cadastrar a turma {2}", turma.Professeor.professor, turma.Turnos, turma.descricao);
                    return RetornosDoModel.Existe;
                }
                mensagem = string.Format("A professora {0} \nfoi cadastrado com êxito, na turma {1}", turma.Professeor.professor, turma.descricao);
                return RetornosDoModel.Cadastrado;
                
                
                
            }
            catch (Exception erro)
            {

                mensagem = erro.Message;
                return RetornosDoModel.Erro;
            }

        }
        public TurmasEnt SelecionarTurmas(string ano,string strcomand , CommandType tipo = CommandType.StoredProcedure) 
        { 
            TurmasEnt alunos = new TurmasEnt();
            TurmaEnt aluno;
            Conexao com = new Conexao();
            SqlDataAdapter adp = new SqlDataAdapter(strcomand, com.NovaConexaoBdAtaFinal());
            adp.SelectCommand.CommandType = tipo;
            adp.SelectCommand.Parameters.AddWithValue("@ano", Convert.ToInt32(ano));
            adp.SelectCommand.Connection.Open();
            SqlDataReader leitor = adp.SelectCommand.ExecuteReader();
            while (leitor.Read())
            {
                aluno = new TurmaEnt();
                aluno.id_turma = int.Parse(leitor["id_turma"].ToString());
                aluno.Ano.id_Ano = int.Parse(leitor["id_ano"].ToString());
                aluno.Ano.id_nivel = (Niveis) int.Parse(leitor["id_nivel"].ToString());
                aluno.Ano.ano = leitor["serie"].ToString().Trim();
                aluno.Turnos = (Turno) int.Parse(leitor["id_turno"].ToString());
                aluno.Professeor.id_prof = int.Parse(leitor["id_professor"].ToString());

                aluno.Professeor.professor = leitor["professor"].ToString().Trim();
                aluno.descricao = leitor["descricao"].ToString().Trim();
                aluno.ano = leitor["ano"].ToString().Trim();
                alunos.Add(aluno);

            }
            adp.SelectCommand.Connection.Close();


            return alunos;
        }
        public TurmaEnt SelecionarTurmasPorId(string strcomand, string ano, int id)
        {
            
            TurmaEnt aluno = new TurmaEnt();
            Conexao com = new Conexao();
            SqlDataAdapter adp = new SqlDataAdapter(strcomand, com.NovaConexaoBdAtaFinal());
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@ano", ano);
            adp.SelectCommand.Parameters.AddWithValue("@id_turma", id);
            adp.SelectCommand.Connection.Open();
            SqlDataReader leitor = adp.SelectCommand.ExecuteReader();
            while (leitor.Read())
            {
                
                aluno.ano = leitor["ano"].ToString();
                aluno.descricao = leitor["descricao"].ToString();
                aluno.Turnos = (Turno) int.Parse(leitor["turno"].ToString());
                aluno.Ano.ano = leitor["serie"].ToString();
                aluno.Professeor.professor = leitor["professor"].ToString();
                aluno.Ano.id_nivel = (Niveis) int.Parse(leitor["id_nivel"].ToString());
                
                aluno.id_turma = Convert.ToInt32(leitor["id_turma"].ToString());
                aluno.Professeor.id_prof = Convert.ToInt32(leitor["id_professor"].ToString());
                
                aluno.Ano.id_Ano = Convert.ToInt32(leitor["id_ano"].ToString());
                

            }
            adp.SelectCommand.Connection.Close();


            return aluno;
        }
        public RetornosDoModel CadastrarSerie(string ano, int nivel)
        {
            try
            {
                Conexao con = new Conexao();
                SqlCommand cmd = new SqlCommand("Cad_serie", con.NovaConexaoBdAtaFinal());
                cmd.Parameters.AddWithValue("@ano", ano);
                cmd.Parameters.AddWithValue("@nivel", nivel);
                cmd.Connection.Open();
                int retorno = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (retorno == -1)
                    return RetornosDoModel.Existe;
                return RetornosDoModel.Cadastrado;
            }
            catch
            {
                return RetornosDoModel.Erro;
            }
        }
        public RetornosDoModel SelecionaProfessores(List<ProfessorEnt> lista,ref string Mensagens)
        {
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("select id_prof, professor from tbl_professor", com.NovaConexaoBdAtaFinal());
                DataTable tbl = new DataTable();
                adp.Fill(tbl);
                if (tbl.Rows.Count == 0)
                {
                    Mensagens = "nenhum professor cadastrado";
                    lista = new List<ProfessorEnt>();
                    return RetornosDoModel.Erro;
                }
                else
                {
                    foreach (DataRow i in tbl.Rows)
                    {
                        lista.Add(new ProfessorEnt 
                        { 
                            id_prof = int.Parse(i[0].ToString()),
                            professor = i[1].ToString()
                        });
                    }
                    return RetornosDoModel.Cadastrado;
                }
            }
            catch (Exception erro)
            {
                Mensagens = erro.Message;
                lista = new List<ProfessorEnt>();
                return RetornosDoModel.Erro;
            }
        }
        public RetornosDoModel CadastrarProfessor(ref ProfessorEnt prof, ref string mensagem)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"if(select COUNT(0) from tbl_professor where professor = @prof) > 0
                                                    print ('professor ja esta cadastrado')
                                                    else
                                                    begin
                                                    INSERT INTO [tbl_professor]
                                                               ([professor]
                                                               ,[tipo_de_usuario]
                                                               ,[login]
                                                               ,[senha])
                                                         VALUES
                                                               (@prof
                                                               ,@tipo
                                                               ,@login
                                                               ,@selnha)
                                                    end", com.NovaConexaoBdAtaFinal());
                cmd.Parameters.AddWithValue("@prof", prof.professor);
                cmd.Parameters.AddWithValue("@tipo", prof.tipo_de_usuario);
                cmd.Parameters.AddWithValue("@login", prof.login);
                cmd.Parameters.AddWithValue("@selnha", prof.senha);
                cmd.Connection.Open();
                int linhasAfetadas = cmd.ExecuteNonQuery();
                
                cmd.CommandText = "Select id_prof from tbl_professor where professor = @prof";
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    prof.id_prof = int.Parse(data[0].ToString());
                }
                cmd.Connection.Close();
                if (linhasAfetadas == -1)
                {
                    mensagem = "Professor já cadastrado";
                    return RetornosDoModel.Existe;
                }
                else
                {
                    mensagem = "professor cadastrado com sucesso";
                    return RetornosDoModel.Cadastrado;
                }
            }
            catch (Exception erro)
            {
                mensagem = erro.Message;
                return RetornosDoModel.Erro;
            }
        }
        public RetornosDoModel DeletaProfessor(ref ProfessorEnt prof, ref string mensage)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from tbl_professor where id_prof = @id", com.NovaConexaoBdAtaFinal());
                cmd.Parameters.AddWithValue("@id", prof.id_prof);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                mensage = "Deletado com sucesso";
                return RetornosDoModel.Cadastrado;
            }
            catch (Exception erro)
            {
                mensage = erro.Message;
                return RetornosDoModel.Erro;
            }
        }
        public RetornosDoModel AlterarProfessor(ref ProfessorEnt prof, ref string msg)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"if(select COUNT(0) from tbl_professor where professor = @profe) > 0
                                                    print ('professor ja cadastrado')
                                                    else
                                                    UPDATE [tbl_professor]
                                                       SET [professor] = @profe
                                                         
                                                     WHERE id_prof = @id", com.NovaConexaoBdAtaFinal());
                cmd.Parameters.AddWithValue("@id", prof.id_prof);
                cmd.Parameters.AddWithValue("@profe", prof.professor);
                
                cmd.Connection.Open();
                int linhasAfetadas = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                if (linhasAfetadas == -1)
                {
                    msg = "já existe um professor com este nome";
                    return RetornosDoModel.Existe;
                }
                else 
                {
                    return RetornosDoModel.Cadastrado;
                }
            }
            catch(Exception erro)
            {
                msg = erro.Message;
                return RetornosDoModel.Erro;
            }
        }
    }
}
