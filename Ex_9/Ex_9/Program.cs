using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Faça um algoritmo para ler o código e o preço de 15 produtos, calcular e escrever:
- o maior preço lido
- a média aritmética dos preços dos produtos*/
namespace Ex_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Precos p = new Precos();
            decimal maior = 0;
            decimal media=0;

            for (int i = 1; i<=15; i++){
                Console.WriteLine("Digite o codigo para o produto " + i);
                p.CodigoProd = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o preco para o produto " + i);
                p.PrecoProd =Convert.ToInt32(Console.ReadLine());
                 
                if(p.PrecoProd > maior)
                {
                    maior = p.PrecoProd;
                }

                media = media + p.PrecoProd;

            }

            media = media / 15;

            Console.WriteLine("Maior preco eh: " + maior);
            Console.WriteLine("Media aritmetica dos precos eh: " + media);

            Console.ReadKey();
        }
    }
}
