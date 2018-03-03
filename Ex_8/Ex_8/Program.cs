using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Lados l = new Lados();

            Console.WriteLine("Digite valor para LADO A: ");
            l.LadoA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite valor para LADO B: ");
            l.LadoB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite valor para LADO C: ");
            l.LadoC = Convert.ToInt32(Console.ReadLine());

            l.ValidarLados();

            Console.ReadKey();
            

        }
    }
}
