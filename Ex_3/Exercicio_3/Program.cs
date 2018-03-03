using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            Console.WriteLine("Digite valor de fabrica: ");
            c.PrecoFabrica = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Valor final do carro: " + c.CalculaValorFinal());
            Console.WriteLine("Valor de fabrica: " + c.PrecoFabrica);
            Console.WriteLine(" \n Percentual do distribuidor seja de 28 % ");
            Console.WriteLine(" \n Impostos de 45%");

            Console.ReadKey();
        }
    }
}
