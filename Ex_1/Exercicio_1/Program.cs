using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Idade i = new Idade();

            Console.WriteLine("Digite quantos ANOS tem");
            i.Ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite quantos MESES tem");
            i.Mes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite quantos DIAS tem");
            i.Dia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sua idade em dias eh: " +i.calcularIdade() +" dias");

            Console.ReadKey();


        }
    }
}
