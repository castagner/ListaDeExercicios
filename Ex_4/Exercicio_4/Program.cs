using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario s = new Salario();



            Console.WriteLine("Digite a quantidade de carros vendidos: ");
            s.CarrosVendido = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite valor da comissão para os carros vendidos: ");
            s.ComCarro = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\n Digite valor total de vendas: ");
            s.TotalVendas = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\n Informe valor do salario fixo: ");
            s.SalarioFixo = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("\n Salario final: " + s.CalcularSalarioFinal());

            Console.ReadKey();

        }
    }
}
