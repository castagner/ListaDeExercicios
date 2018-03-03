using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Votos v = new Votos();
            int total = 0;

            Console.WriteLine("Digite a quantidade total de eleitores: ");
            v.TotalEleitores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de votos em BRANCO: ");
            v.Branco = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de votos em NULO: ");
            v.Nulo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de votos em VALIDO: ");
            v.Valido = Convert.ToInt32(Console.ReadLine());

            total = v.Branco + v.Nulo + v.Valido;

            if( total > v.TotalEleitores)
            {
                Console.WriteLine("Quantidade de votos superou o total de Eleitores. \n Aplicacao ENCERRADA!!");
                Console.ReadKey();
                Environment.Exit(0);
                

            }

            Console.WriteLine (v.calculaVotos());

            Console.ReadKey();
        }
    }
}
