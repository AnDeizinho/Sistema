using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using SistemaShekinahCompleto.Entidades;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace SistemaShekinahCompleto.Model
{
    public class DbAlunos
    {
        public void RenovarMatricula(AtaFinalEnt bi)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand(@"insert into tbl_Notas values(
            @id_aluno
           ,@ano
           ,@port
           ,@mat
           ,@hist
           ,@geog
           ,@ciencia
           ,@arte
           ,@religiao
           ,@ingles
           ,@fisica
           ,@ap
           ,@r
           ,@des
           ,@tr
           ,@faltas
           ,@id_turma
           ,@Serie
           ,@Instituicao)", con.NovaConexaoBdAtaFinal());
            try
            {
                //bi.b1 = new BimestreEnt(0, bi.Id_Aluno, bi.Id_Turma, 0, 1, bi.Ano, bi.Serie);
                //bi.b2 = new BimestreEnt(0, bi.Id_Aluno, bi.Id_Turma, 0, 2, bi.Ano, bi.Serie);
                //bi.b3 = new BimestreEnt(0, bi.Id_Aluno, bi.Id_Turma, 0, 3, bi.Ano, bi.Serie);
                //bi.b4 = new BimestreEnt(0, bi.Id_Aluno, bi.Id_Turma, 0, 4, bi.Ano, bi.Serie);
                CadBi(bi.b1);
                CadBi(bi.b2);
                CadBi(bi.b3);
                CadBi(bi.b4);
                cmd.Parameters.AddWithValue("@id_aluno", bi.Id_Aluno);
                cmd.Parameters.AddWithValue("@ano", bi.Ano);
                cmd.Parameters.AddWithValue("@port", bi.Portugues.Nota);
                cmd.Parameters.AddWithValue("@mat", bi.Matematica.Nota);
                cmd.Parameters.AddWithValue("@hist", bi.Historia.Nota);
                cmd.Parameters.AddWithValue("@geog", bi.Geografia.Nota);
                cmd.Parameters.AddWithValue("@ciencia", bi.Ciencia.Nota);
                cmd.Parameters.AddWithValue("@arte", bi.Artes.Nota);
                cmd.Parameters.AddWithValue("@religiao", bi.Religiao.Nota);
                cmd.Parameters.AddWithValue("@ingles", bi.Ingles.Nota);
                cmd.Parameters.AddWithValue("@fisica", bi.Fisica.Nota);
                cmd.Parameters.AddWithValue("@ap", bi.Ap);
                cmd.Parameters.AddWithValue("@r", bi.R);
                cmd.Parameters.AddWithValue("@des", bi.Des);
                cmd.Parameters.AddWithValue("@tr", bi.Tr);
                cmd.Parameters.AddWithValue("@faltas", bi.Faltas);
                cmd.Parameters.AddWithValue("@Serie", bi.Serie);
                cmd.Parameters.AddWithValue("@id_turma", bi.Id_Turma);
                cmd.Parameters.AddWithValue("@Instituicao", bi.Instituicao);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }
        }
        void CadBi(BimestreEnt bi)
        {
            Conexao con = new Conexao();
            SqlCommand cmd = new SqlCommand(@"insert into tbl_bimestre ([id_aluno]
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
           ,[id_turma]
           ,[Serie])
            values(
            @id_aluno
           ,@ano
           ,@port
           ,@mat
           ,@hist
           ,@geog
           ,@ciencia
           ,@arte
           ,@religiao
           ,@ingles
           ,@fisica
           ,@ap
           ,@r
           ,@faltas
           ,@Bimestre
           ,@id_turma,@Serie)", con.NovaConexaoBdAtaFinal());
            try
            {
                   cmd.Parameters.AddWithValue("@id_aluno",bi.Id_Aluno);
                   cmd.Parameters.AddWithValue("@ano",bi.Ano);
                   cmd.Parameters.AddWithValue("@port",bi.Portugues.Nota);
                   cmd.Parameters.AddWithValue("@mat", bi.Matematica.Nota);
                   cmd.Parameters.AddWithValue("@hist",bi.Historia.Nota);
                   cmd.Parameters.AddWithValue("@geog",bi.Geografia.Nota);
                   cmd.Parameters.AddWithValue("@ciencia",bi.Ciencia.Nota);
                   cmd.Parameters.AddWithValue("@arte",bi.Artes.Nota);
                   cmd.Parameters.AddWithValue("@religiao",bi.Religiao.Nota);
                   cmd.Parameters.AddWithValue("@ingles",bi.Ingles.Nota);
                   cmd.Parameters.AddWithValue("@fisica",bi.Fisica.Nota);
                   cmd.Parameters.AddWithValue("@ap",bi.Ap);
                   cmd.Parameters.AddWithValue("@r",bi.R);
                   cmd.Parameters.AddWithValue("@faltas",bi.Faltas);
                   cmd.Parameters.AddWithValue("@Bimestre",bi.Bimestre);
                   cmd.Parameters.AddWithValue("@id_turma",bi.Id_Turma);
                   cmd.Parameters.AddWithValue("@Serie", bi.Serie);
                   cmd.Connection.Open();
                   cmd.ExecuteNonQuery();
                   

            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                cmd.Connection.Close();
                cmd.Connection.Dispose();
                cmd.Dispose();
            }
        }
        public AlunosEnt SelectAlunos(string strCommando, int id_turma)
        {
            AlunosEnt alunos = new AlunosEnt();
            AlunoEnt aluno;
            Conexao con = new Conexao();
           

            SqlDataAdapter adp = new SqlDataAdapter(strCommando, con.NovaConexaoBdAtaFinal());
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@ano", DateTime.Now.Year.ToString());
            adp.SelectCommand.Parameters.AddWithValue("@idTurma", id_turma);
            adp.SelectCommand.Connection.Open();
            SqlDataReader leitor = adp.SelectCommand.ExecuteReader();
            while (leitor.Read())
            {
                aluno = new AlunoEnt();
                aluno.id_aluno = leitor.GetInt32(0);
                aluno.id_cliente = leitor.GetInt32(1);
                aluno.nome = leitor[2].ToString();
                aluno.pai = leitor[3].ToString();
                aluno.mae = leitor[4].ToString();
                aluno.fone_pai = leitor[5].ToString();
                aluno.fone_mae = leitor[6].ToString();
                aluno.ano_recente = leitor[7].ToString();
                aluno.turma.descricao = leitor[8].ToString();
                aluno.nascimento = DataEnull(leitor[9].ToString());
                aluno.sexo = leitor[10].ToString();
                aluno.naturalidade = leitor[11].ToString();
                aluno.uf = leitor[12].ToString();
                aluno.dadosClinicos = leitor[13].ToString();
                aluno.remedios = leitor[14].ToString();
                aluno.id_mac = leitor[15].ToString();
                aluno.integral = leitor[16].ToString();
                alunos.Add(aluno);
            }
            adp.SelectCommand.Connection.Close();
            return alunos;
        }
        public AlunoEnt SelectAlunoPorId(string str, int idAluno)
        {
            SqlCommand cmd = new SqlCommand(str, new Conexao().NovaConexaoBdAtaFinal());
            AlunoEnt al;
            try
            {
                cmd.Parameters.AddWithValue("@id", idAluno);
                cmd.Connection.Open();
                SqlDataReader l =  cmd.ExecuteReader();
                if (l.Read())
                {
                    al = new AlunoEnt()
                    {
                        id_aluno = int.Parse(l["id_aluno"].ToString()),
                        nome = l["nome"].ToString(),
                        id_cliente = int.Parse(l["id_cliente"].ToString()),
                        ano_recente = l["ano_recente"].ToString(),
                        nascimento = DateTime.Parse(l["nascimento"].ToString()),
                        sexo = l["sexo"].ToString(),
                        naturalidade = l["naturalidade"].ToString().Trim(),
                        uf = l["uf"].ToString(),
                        dadosClinicos = l["dadosClinicos"].ToString().Trim(),
                        remedios = l["remedios"].ToString(),
                        id_mac = l["id_mac"].ToString(),
                        integral = l["integral"].ToString(),
                        turma = new TurmaEnt
                        {
                            id_turma = int.Parse(l["id_turma"].ToString())
                            ,
                            descricao = l["descricao"].ToString().Trim(),
                            ano = l["ano"].ToString(),
                            Professeor = new ProfessorEnt
                            {
                                id_prof = int.Parse(l["id_prof"].ToString()),
                                professor = l["professor"].ToString().Trim(),

                            },
                            Ano = new AnoEnt
                            {
                                id_Ano = int.Parse(l["id_ano"].ToString()),
                                ano = l["ano"].ToString(),
                                id_nivel = (Niveis)int.Parse(l["id_nivel"].ToString())
                            }
                            ,
                            Turnos = (Turno)int.Parse(l["id_turno"].ToString())
                        }
                    };
                }
                else
                {
                    throw new Exception("Aluno não encontrado");
                }
                return al;
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                cmd.Connection.Close();
                
            }   
        }
        public AlunosEnt SelectAlunos(string strCommando)
        {
            AlunosEnt alunos = new AlunosEnt();
            AlunoEnt aluno;
            Conexao con = new Conexao();
            

            SqlDataAdapter adp = new SqlDataAdapter(strCommando, con.NovaConexaoBdAtaFinal());
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@ano", DateTime.Now.Year.ToString());
            adp.SelectCommand.Connection.Open();
            SqlDataReader leitor = adp.SelectCommand.ExecuteReader();
            while (leitor.Read())
            {
                aluno = new AlunoEnt();
                aluno.id_aluno = leitor.GetInt32(0);
                aluno.id_cliente = leitor.GetInt32(1);
                aluno.nome = leitor[2].ToString();
                aluno.pai = leitor[3].ToString();
                aluno.mae = leitor[4].ToString();
                aluno.fone_pai = leitor[5].ToString();
                aluno.fone_mae = leitor[6].ToString();
                aluno.ano_recente = leitor[7].ToString();
                aluno.turma.descricao = leitor[8].ToString();
                aluno.nascimento = DataEnull( leitor[9].ToString());
                aluno.sexo = leitor[10].ToString();
                aluno.naturalidade = leitor[11].ToString();
                aluno.uf = leitor[12].ToString();
                aluno.dadosClinicos = leitor[13].ToString();
                aluno.remedios = leitor[14].ToString();
                aluno.id_mac = leitor[15].ToString();
                aluno.integral = leitor[16].ToString();
                alunos.Add(aluno);
            }
            adp.SelectCommand.Connection.Close();
            return alunos;
        }
        DateTime DataEnull(string data)
        {
            if(data == "")
            {
                return Convert.ToDateTime("01-01-1980").Date;
            }
            return Convert.ToDateTime(data).Date;
        }
        public string InsertAlunos(AlunoEnt aluno)
        {
            Conexao con = new Conexao();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertAlunos", con.NovaConexaoBdAtaFinal());
                cmd.CommandText = @"
                                    if(select count(nome) from tbl_alunos where nome = @nome) > 0
                                        print ('já existe um aluno com este nome')
                                    else

                                    INSERT INTO [dbo].[tbl_Alunos]
                                   ([nome]
                                   ,[id_cliente]
                                   ,[ano_recente]
                                   ,[id_turma]
                                   ,[nascimento]
                                   ,[sexo]
                                   ,[naturalidade]
                                   ,[uf]
                                   ,[dadosClinicos]
                                   ,[remedios]
                                   ,[id_mac]
                                   ,[integral]) 
                                    
                                    values (
                                    @nome
                                   ,@id_cliente
                                   ,@ano_recente
                                   ,@id_turma
                                   ,@nascimento
                                   ,@sexo
                                   ,@naturalidade
                                   ,@uf
                                   ,@dadosClinicos
                                   ,@remedios
                                   ,@id_mac
                                   ,@integral)
                                    ";
                cmd.Parameters.AddWithValue("@id_aluno", aluno.id_aluno);
                cmd.Parameters.AddWithValue("@nome", aluno.nome);
                cmd.Parameters.AddWithValue("@id_cliente", aluno.id_cliente);
                cmd.Parameters.AddWithValue("@ano_recente", aluno.ano_recente);
                cmd.Parameters.AddWithValue("@id_turma", aluno.turma.id_turma);
                cmd.Parameters.AddWithValue("@nascimento", aluno.nascimento);
                cmd.Parameters.AddWithValue("@sexo", aluno.sexo);
                cmd.Parameters.AddWithValue("@naturalidade", aluno.naturalidade);
                cmd.Parameters.AddWithValue("@uf", aluno.uf);
                cmd.Parameters.AddWithValue("@dadosClinicos", aluno.dadosClinicos); 
                cmd.Parameters.AddWithValue("@remedios", aluno.remedios);
                cmd.Parameters.AddWithValue("@id_mac", aluno.id_mac);
                cmd.Parameters.AddWithValue("@integral", aluno.integral);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select id_aluno from tbl_alunos where nome = @nome and id_cliente = @id_cliente";
                
                cmd.CommandType = CommandType.Text;
                SqlDataReader li = cmd.ExecuteReader();
                while (li.Read())
                    aluno.id_aluno = int.Parse(li[0].ToString());
                cmd.Connection.Close();
                if (aluno.turma.Ano.id_nivel == Niveis.Fundamental)
                {
                    AtaFinalEnt ata = new AtaFinalEnt(aluno, new GetSerie(aluno.turma.Ano.id_Ano).Serie);
                    RenovarMatricula(ata);
                }

                return con.mensagens;

            }
            catch (Exception erro)
            {
                return erro.ToString();
            }
        }
        public string AtualizaAlunos(AlunoEnt aluno)
        {
            Conexao con = new Conexao();

            try
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateAlunos", con.NovaConexaoBdAtaFinal());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_aluno", aluno.id_aluno);
                cmd.Parameters.AddWithValue("@nome", aluno.nome);
                cmd.Parameters.AddWithValue("@id_cliente", aluno.id_cliente);
                cmd.Parameters.AddWithValue("@ano_recente", aluno.ano_recente);
                cmd.Parameters.AddWithValue("@id_turma", aluno.turma.id_turma);
                cmd.Parameters.AddWithValue("@nascimento", aluno.nascimento);
                cmd.Parameters.AddWithValue("@sexo", aluno.sexo);
                cmd.Parameters.AddWithValue("@naturalidade", aluno.naturalidade);
                cmd.Parameters.AddWithValue("@uf", aluno.uf);
                cmd.Parameters.AddWithValue("@dadosClinicos", aluno.dadosClinicos);
                cmd.Parameters.AddWithValue("@remedios", aluno.remedios);
                cmd.Parameters.AddWithValue("@id_mac", aluno.id_mac);
                cmd.Parameters.AddWithValue("@integral", aluno.integral);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Clone();
                return con.mensagens;

            }
            catch (Exception erro)
            {
                return erro.ToString();
            }
        }
    }
}
