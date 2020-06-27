using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaSimples
{
    public static class Extencoes
    {
        public static int ToInt(this string valor)
        {
            return int.Parse(valor);
        }
    }
}
