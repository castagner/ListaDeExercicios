using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 
namespace Ex_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario s = new Salario();

            Console.WriteLine("Digite o salario fixo: ");
            s.SalarioFixo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite total das vendas: ");
            s.ValorVendas = Convert.ToDecimal(Console.ReadLine());

            s.CalcularSalario();

            Console.ReadKey();
        }
    }
}
