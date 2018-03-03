using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Votos
    {
        public int TotalEleitores { get; set; }
        public int Branco { get; set; }
        public int Nulo { get; set; }
        public int Valido { get; set; }

        public String calculaVotos()
        {
            Decimal pBranco = (Branco * 100) / TotalEleitores;
            Decimal pNulo = (Nulo * 100) / TotalEleitores; ;
            Decimal pValido = (Valido * 100) / TotalEleitores; ;



            return "Percentual  Branco: " + pBranco  + "% \n Percentual nulo: " + Nulo + "% \n Percentual validos: " + pValido +"%";
        }
    }
}
