using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaShekinahCompleto.Entidades
{
    

    public class BimestreEnt
    {
        long id_bimestre;
        int id_aluno, id_turma, faltas, bimestre, ano;
       
        string ap = "", r = "", serie = "";


        public Materia[] mats = {
                         new Materia(0,"Português"),
                         new Materia(0,"Matemática"),
                         new Materia(0,"História"),
                         new Materia(0,"Geografia"),
                         new Materia(0,"Ciência"),
                         new Materia(0,"Artes"),
                         new Materia(0,"Religião"),
                         new Materia(0,"Inglês"),
                         new Materia(0,"Ed. Física")
                         };
        ///propriedades
        public long Id_Bimestre{get {return id_bimestre;}}
        public int Id_Aluno { get { return id_aluno; } }
        public int Id_Turma { get { return id_turma; } }
        public int Faltas { get { return faltas; } }
        public int Bimestre { get { return bimestre; } }
        public int Ano { get { return ano; } }
        public string Ap { get { return ap; } }
        public string R{get{return r;}}
        public string Serie { get { return serie; } }
        public Materia Portugues { get { return mats[0]; } set { mats[0] = value; } }
        public Materia Matematica { get { return mats[1]; } set { mats[1] = value; } }
        public Materia Historia { get { return mats[2]; } set { mats[2] = value; } }
        public Materia Geografia { get { return mats[3]; } set { mats[3] = value; } }
        public Materia Ciencia { get { return mats[4]; } set { mats[4] = value; } }
        public Materia Artes { get { return mats[5]; } set { mats[5] = value; } }
        public Materia Religiao { get { return mats[6]; } set { mats[6] = value; } }
        public Materia Ingles { get { return mats[7]; } set { mats[7] = value; } }
        public Materia Fisica { get { return mats[8]; } set { mats[8] = value; } }
        
        //Construtor
        public BimestreEnt(long _id,int _id_aluno, int _id_turma, int _faltas, int _bimestre, int _ano, double por,
            double mat, double hist, double geog, double cien, double art, double reli, double ingl, double fis,
            string _ap, string _r, string _serie)
        {
            id_bimestre = _id; id_aluno = _id_aluno; id_turma = _id_turma; faltas = _faltas; bimestre = _bimestre;
            ano = _ano; Portugues.Nota = por; Matematica.Nota = mat; Historia.Nota = hist; Geografia.Nota = geog;
            Ciencia.Nota = cien; Artes.Nota = art; Religiao.Nota = reli; Ingles.Nota = ingl; Fisica.Nota = fis;
            ap = _ap; r = _r; serie = _serie;
            calculaM();
        }
        //metodos publicos
        public BimestreEnt(long _id, int _id_aluno, int _id_turma, int _faltas, int _bimestre, int _ano, string _serie)
        {
            id_bimestre = _id; id_aluno = _id_aluno; id_turma = _id_turma; faltas = _faltas; bimestre = _bimestre;
            ano = _ano; serie = _serie;//falta a serie
        }
        public BimestreEnt(System.Data.SqlClient.SqlDataReader li)
        {
            throw new NotImplementedException();
        }
        //metodos privados
        void calculaM()
        {
            int nr = 0;
            foreach (Materia m in mats)
            {
                if (m.Nota < 6)
                    nr++;
            }
            if (nr > 3)
            {
                r = "r";
                ap = "";
            }
            else
            {
                ap = "ap";
                r = "";
            }


        }
        


    }
}
