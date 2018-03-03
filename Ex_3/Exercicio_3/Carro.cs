using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Carro
    {
        public Decimal PrecoFabrica { get; set; }
        Decimal valotTotal =0;


        public Decimal CalculaValorFinal()
        {
            valotTotal= PrecoFabrica +(PrecoFabrica * 0.45m + PrecoFabrica*0.28m);
            
            return valotTotal;
        }

    }
}
