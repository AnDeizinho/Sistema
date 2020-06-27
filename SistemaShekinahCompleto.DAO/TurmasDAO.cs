using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaShekinahCompleto.Model;
using SistemaShekinahCompleto.Entidades;
namespace SistemaShekinahCompleto.DAO
{
    public class TurmasDAO
    {
        DbTurmas bd = new DbTurmas();
        public RetornosDoModel AtualizaTurma(TurmaEnt turma, out string msg)
        {
            if (turma.descricao.Length >= 20)
                throw new Exception("a descriçao deve conter somente 20 caracteres");
            if (turma.descricao.Length <= 5)
                throw new Exception("digite o ano e o turno na descricão");

            return bd.AtualizaTurmas(turma, out msg);
        }
        public RetornosDoModel CadastraTurma(TurmaEnt turma, out string msg)
        {
            if (turma.descricao.Length >= 20)
                throw new Exception("a descriçao deve conter somente 20 caracteres");
            if (turma.descricao.Length <= 5)
                throw new Exception("digite o ano e o turno na descricão");
            
            return bd.CadastraTurmas(turma, out msg);
        }
        public TurmasEnt SelectTurmas(string ano)
        {
            try
            {
                
                return bd.SelecionarTurmas("tbl_turma_Tudo", ano);
            }
            catch
            {
                return new TurmasEnt();
            }
        }
        public TurmaEnt SelectTurmaPorId(string ano, int id)
        {
            try
            {
                
                return bd.SelecionarTurmasPorId("tbl_turma_PorId", ano, id);
            }
            catch
            {
                return new TurmaEnt();
            }
        }
        public string CadastraAno(AnoEnt ano)
        {
           
            RetornosDoModel reto = bd.CadastrarSerie(ano.ano,(int) ano.id_nivel);
            string mensagem = "";
            switch (reto)
            {
                case RetornosDoModel.Existe:
                    mensagem = "Ano ja Cadastrado";
                    break;
                case RetornosDoModel.Cadastrado:
                    mensagem = "cadastrado com sucesso";
                    break;
                case RetornosDoModel.Erro:
                    mensagem = "erro ao Cadastrar ano";
                    break;
            }
            return mensagem;
            
        }
        public RetornosDoModel CarregaProfessores(List<ProfessorEnt> prof, ref string mensagem)
        {
           
            return bd.SelecionaProfessores(prof, ref mensagem);
        }
        public RetornosDoModel InsertProfessor(ref ProfessorEnt prof, ref string msg)
        {
            
            if (prof.professor.Length <= 5)
            {
                msg = "nome do professor inválido";
                return RetornosDoModel.Erro;
            }

            if (prof.professor == null)
            {
                msg = "nome do professor inválido";
                return RetornosDoModel.Erro;
            }

            return bd.CadastrarProfessor(ref prof, ref msg);
        }
        public RetornosDoModel DeletarProfessor(ref ProfessorEnt prof, ref string msg)
        {
            
            return bd.DeletaProfessor(ref prof, ref msg);

        }

        public RetornosDoModel AlterarProfessor(ref ProfessorEnt prof, ref string mesg)
        {
            return bd.AlterarProfessor(ref prof, ref mesg);
        }
    }
}
