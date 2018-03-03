using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7
{
    class Numeros
    {
        public int Nro1 { get; set; }
        public int Nro2 { get; set; }
        public int Nro3 { get; set; }


        public void ValidarMaior()
        {
            if(Nro1 > Nro2 && Nro1 > Nro3)
            {
                Console.WriteLine("O numero " + Nro1 + " eh o maior");
            }
            else
            {
                if(Nro2 > Nro1 && Nro2 > Nro3)
                {
                    Console.WriteLine("O numero " + Nro2 + " eh o maior");

                }
                else
                {
                    Console.WriteLine("O numero " + Nro3 + " eh o maior");
                }
            }
        }
    }
}
