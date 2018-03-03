using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Idade
    {
        public int Ano { get; set; }
        public int Mes { get; set; }
        public int Dia { get; set; }

        public int calcularIdade()
        {
            int idade = 0;

            return idade = (Ano * 365) + (Mes * 30) + Dia;
        }

    }
}
