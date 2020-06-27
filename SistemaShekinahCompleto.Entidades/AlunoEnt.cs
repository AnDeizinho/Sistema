using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaShekinahCompleto.Entidades
{
    
    public class AlunoEnt : ClienteAbs
    {
        int _id;
        string _nome;
        public int id_aluno { get { return _id; } set { _id = value; } }
        //public int id_cliente { get; set; }
        public string nome { 
            get 
            {
                return _nome;
            }
            set { _nome = value; }
        }
        public string ano_recente { get; set; }
        TurmaEnt _turma = new TurmaEnt();
        public TurmaEnt turma
        {
            get
            {
                 return _turma;
            }
            set
            {
                _turma = value;
            }
        }
        public DateTime nascimento { get; set; }
        public string sexo { get; set; }
        public string naturalidade { get; set; }
        public string uf { get; set; }
        public string dadosClinicos { get; set; }
        public string remedios { get; set; }
        public string id_mac { get; set; }
        public string integral { get; set; }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine(string.Format("CA = {0}", id_aluno));
            str.AppendLine(string.Format("CC = {0}", id_cliente));
            str.AppendLine(string.Format("Nome = {0}", nome));
            
            str.AppendLine(string.Format("Descricao = {0}", turma.descricao));
            str.AppendLine(string.Format("Nascimento = {0}", nascimento));
            str.AppendLine(string.Format("Sexo = {0}", sexo));
            str.AppendLine(string.Format("Naturalidade = {0}", naturalidade));
            str.AppendLine(string.Format("UF = {0}", uf));
            str.AppendLine(string.Format("Dados Clínicos = {0}",dadosClinicos));
            str.AppendLine(string.Format("Remédios = {0}", remedios));
            str.AppendLine(string.Format("Id do MAC = {0}", id_mac));
            str.AppendLine(string.Format("Integral = {0}", integral));
            return str.ToString();

        }
        
    }
}
