using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Ler 3 valores (considere que não serão informados valores iguais)e escrever o maior deles*/

namespace Ex_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros n = new Numeros();

            Console.WriteLine("Digite o primeiro numero: ");
            n.Nro1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Digite o segundo numero: ");
            n.Nro2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero: ");
            n.Nro3 = Convert.ToInt32(Console.ReadLine());

            

            n.ValidarMaior();

            Console.ReadKey();
        }
    }
}
