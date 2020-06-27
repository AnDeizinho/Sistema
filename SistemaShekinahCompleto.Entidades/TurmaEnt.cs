using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace SistemaShekinahCompleto.Entidades
{
    public class TurmaEnt
    {
        public int id_turma {get;set;}
        public AnoEnt Ano { get; set; }

        public Turno Turnos { get; set; }
        public ProfessorEnt Professeor { get; set; }
      
        public string descricao {get;set;}
        public string ano { get; set; }
        public TurmaEnt()
        {
            Ano = new AnoEnt();
            Professeor = new ProfessorEnt();
        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", descricao, Professeor.professor, ano);
        }
        
    }
}
