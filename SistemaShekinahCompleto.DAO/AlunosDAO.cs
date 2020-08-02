using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SistemaShekinahCompleto.Model;
using SistemaShekinahCompleto.Entidades;
using System.Data.SqlClient;
namespace SistemaShekinahCompleto.DAO
{
    public class AlunosDAO
    {
        DbAlunos alunos = new DbAlunos();
        public void RenovarMatricula(AlunoEnt al)
        {
            SqlCommand cmd = new SqlCommand(string.Format("select count(id_aluno) from tbl_notas where ano = {0} and id_aluno = {1}", al.ano_recente, al.id_aluno), new Conexao().NovaConexaoBdAtaFinal());
            try
            {
                cmd.Connection.Open();
                int valor = (int)cmd.ExecuteScalar();
                if (valor > 0)
                    throw new Exception("aluno já renovou matrícula");
                alunos.RenovarMatricula(new AtaFinalEnt(al, new GetSerie(al.turma.Ano.id_Ano).Serie));
            }
            catch (Exception erro)
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
        public AlunoEnt SelectPorId(int id)
        {
            try
            {
                return alunos.SelectAlunoPorId(@"SELECT *
              FROM [tbl_Alunos] al
              join tbl_turma tur on al.id_turma = tur.id_turma
              join tbl_professor prof on tur.id_professor = prof.id_prof
              join tblAno ano on tur.id_ano = ano.id_Ano
              join tbl_Niveis niv on ano.id_nivel= niv.id_nivel where id_aluno = @id", id);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public AlunosEnt TodosOsAlunos()
        {
            try
            {
                return alunos.SelectAlunos("tbl_alunos_select_tudo");
            }
            catch
            {
                return new AlunosEnt();
            }
        }
        public AlunosEnt TodosOsAlunos(int Id_turma)
        {
            try
            {
                return alunos.SelectAlunos("tbl_alunos_select_tudo_porTurma", Id_turma);
            }
            catch
            {
                return new AlunosEnt();
            }
        }
        public string InserirNovoAluno(AlunoEnt al)
        {
            if (al.nome == "" || al.nome == null)
                throw new ArgumentException("Nome do aluno é obrigatório");
            if (al.id_cliente == 0)
                throw new ArgumentException("CC invalido");
            if (al.turma.id_turma == 0)
                throw new ArgumentException("informe qual a turma do aluno");
            if (al.nascimento.Date <= DateTime.Now.AddYears(-15).Date || al.nascimento.Date > DateTime.Now.Date)
                throw new ArgumentException("Data de nascimento inválida");
            if (al.sexo == "" || al.sexo == null)
                throw new ArgumentException("Informe qual o gênero do aluno");
            return alunos.InsertAlunos(al);
        }
        public string AtualizarAluno(AlunoEnt al)
        {
            return alunos.AtualizaAlunos(al);
        }
    }
}
