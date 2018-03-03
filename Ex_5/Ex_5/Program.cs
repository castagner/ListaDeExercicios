using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Peso p = new Peso();

            Console.WriteLine("Digite seu nome: ");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua altura: ");
            p.Altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o SEXO \n 1-M ou 2-F");
            p.Sexo = Convert.ToInt32(Console.ReadLine());

            switch (p.Sexo)
            {
                case 1:
                    Console.WriteLine("Peso ideal: " + ((72.7m * p.Altura) - 58));
                    break;
                case 2:
                    Console.WriteLine("Peso ideal: " + ((62.1m * p.Altura) - 44.7m));
                    break;
                default:
                    Console.WriteLine("Opcao INVALIDA");
                    break;
            }

            Console.ReadKey();




        }
    }
}
