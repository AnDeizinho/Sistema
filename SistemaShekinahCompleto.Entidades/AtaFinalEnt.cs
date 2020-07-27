using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaShekinahCompleto.Entidades
{
    public class AtaFinalEnt
    {
        int id_atafinal, id_aluno, ano, faltas, id_turma;
        string ap = "", r = "", des = "", tr = "", serie = "", instituicao = "";
        public BimestreEnt b1, b2, b3, b4;
        public Materia[] mats;
        //propriedades
        public int Id_AtaFinal { get { return id_aluno; } }
        public int Id_Aluno { get { return id_aluno; } }
        public int Id_Turma{get{return id_turma;}}
        public int Ano { get { return ano; } }
        public int Faltas { get { return faltas; } }
        public string Ap { get { return ap; } }
        public string R { get { return r; } }
        public string Des { get { return des; } }
        public string Tr { get { return tr; } }
        public string Serie { get { return serie; } }
        public string Instituicao { get { return instituicao; } }
        public Materia Portugues { get { return mats[0]; }  }
        public Materia Matematica { get { return mats[1]; } }
        public Materia Historia { get { return mats[2]; }}
        public Materia Geografia { get { return mats[3]; }  }
        public Materia Ciencia { get { return mats[4]; }   }
        public Materia Artes { get { return mats[5]; } }
        public Materia Religiao { get { return mats[6]; } }
        public Materia Ingles { get { return mats[7]; } }
        public Materia Fisica { get { return mats[8]; } }
        //metodos privados
        double calulaMedia(int i)
        {
            return b1.mats[i].Nota + b2.mats[i].Nota + b3.mats[i].Nota + b4.mats[i].Nota / 4;
        }
        void definirMedia(BimestreEnt[] b, int i, double nota)
        {
            b[0].mats[i].Nota = nota;
            b[1].mats[i].Nota = nota;
            b[2].mats[i].Nota = nota;
            b[3].mats[i].Nota = nota;
        }
        void inicia()
        {
            mats = new Materia[]{
                         new Materia(calulaMedia(0),"Português"),
                         new Materia(calulaMedia(1),"Matemática"),
                         new Materia(calulaMedia(2),"História"),
                         new Materia(calulaMedia(3),"Geografia"),
                         new Materia(calulaMedia(4),"Ciência"),
                         new Materia(calulaMedia(5),"Artes"),
                         new Materia(calulaMedia(6),"Religião"),
                         new Materia(calulaMedia(7),"Inglês"),
                         new Materia(calulaMedia(8),"Ed. Física")
                         };
            
        }
        //metodos publicos

        public AtaFinalEnt(AlunoEnt al, string _serie)
        {
            
            id_aluno = al.id_aluno; ano = int.Parse(al.ano_recente); id_turma = al.turma.id_turma; serie = _serie;
            b1 = new BimestreEnt(0, al.id_aluno, al.turma.id_turma, 0, 1, Ano, _serie);
            b2 = new BimestreEnt(0, al.id_aluno, al.turma.id_turma, 0, 2, Ano, _serie);
            b3 = new BimestreEnt(0, al.id_aluno, al.turma.id_turma, 0, 3, Ano, _serie);
            b4 = new BimestreEnt(0, al.id_aluno, al.turma.id_turma, 0, 4, Ano, _serie);
            inicia();
            
        }
        public void defineMedi(double por,
            double mat, double hist, double geog, double cien, double art, double reli, double ingl, double fis)
        {
            definirMedia(new BimestreEnt []{ b1, b2, b3, b4 }, 0, por);
            definirMedia(new BimestreEnt[] { b1, b2, b3, b4 }, 1, mat);
            definirMedia(new BimestreEnt[] { b1, b2, b3, b4 }, 2, hist);
            definirMedia(new BimestreEnt[] { b1, b2, b3, b4 }, 3, geog);
            definirMedia(new BimestreEnt[] { b1, b2, b3, b4 }, 4, cien);
            definirMedia(new BimestreEnt[] { b1, b2, b3, b4 }, 5, art);
            definirMedia(new BimestreEnt[] { b1, b2, b3, b4 }, 6, reli);
            definirMedia(new BimestreEnt[] { b1, b2, b3, b4 }, 7, ingl);
            definirMedia(new BimestreEnt[] { b1, b2, b3, b4 }, 8, fis);

        }

    }
}
