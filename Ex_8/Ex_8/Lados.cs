using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8
{
    class Lados
    {
        public int LadoA { get; set; }
        public int LadoB { get; set; }
        public int LadoC { get; set; }

        public void ValidarLados()
        {
            
                if ( (LadoA < (LadoB + LadoC)) && (LadoB < (LadoA + LadoC))  && (LadoC < (LadoA + LadoB)))
                {
                    Console.WriteLine("Medidas Validas");
                }else
                {
                    Console.WriteLine("Medidas INVALIDAS");
                }
        }
    }
}

