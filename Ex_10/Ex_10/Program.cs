using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*10. A prefeitura de uma cidade deseja fazer uma pesquisa entre seus habitantes. Faça um
algoritmos para coletar dados sobre o salário e número de filhos de 4 habitantes e após as
leituras, escrever:
a) Média de salário da população
b) Média do número de filhos
c) Maior salário dos habitantes
d) Percentual de pessoas com salário menor que R$ 150,00*/

namespace Ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Habitantes h = new Habitantes();

            for (int i =0; i<4; i++)
            {
                Console.WriteLine("Digite valor do salario: ");
                h.Salario = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite a quantidade de filhos: ");
                h.Filhos = Convert.ToInt32(Console.ReadLine());

                h.CalcularMaiorSalario();
                h.CalcularMediaFilho();
                h.CalcularMediaSalario();
                h.CalcularPercentualSalarioBaixo();

            }

            Console.WriteLine("Media Salario: " +h.media / 4);
            Console.WriteLine("Media de filhos: " + h.mediaFilho / 4);
            Console.WriteLine("Maior salario: " + h.maiorS);
            Console.WriteLine("Percentual de salario menos que 150: " + h.pecSal);

            Console.ReadKey();

        }
    }
}
