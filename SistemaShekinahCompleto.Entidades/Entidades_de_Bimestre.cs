using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaShekinahCompleto.Entidades
{
    public class Materia
    {
        double _nota;
        protected string orig = "Nota";

        public double Nota { get { return _nota; } set { _nota = validaNotas(value, orig); } }
        double validaNotas(double valor, string orig)
        {
            if (valor < 0)
                throw new ArgumentException("Nota não pode ser negativa", orig);
            if (valor > 10)
                throw new ArgumentException("Nota não pode ser maior que 10", orig);
            return valor;
        }
        public override string ToString()
        {
            return orig;
        }
        public Materia(double N, string Nome)
        {
            Nota = N;
            orig = Nome;
        }
    }
   
}


