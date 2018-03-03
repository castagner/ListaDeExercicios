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
    class Habitantes
    {
        public decimal Salario { get; set; }
        public int Filhos { get; set; }

        public decimal maiorS = 0;
        public decimal media = 0;
        public decimal mediaFilho =0;
        public decimal mediaSalarioBaixo = 0, pecSal=0;
        public int qtd = 0;

        public void CalcularMediaSalario()
        {
            media = media + Salario;
        }

        public void CalcularMediaFilho()
        {
            mediaFilho = mediaFilho + Filhos;
        }
        public void CalcularMaiorSalario()
        {
            if(Salario > maiorS)
            {
                maiorS = Salario;
            }
        }

        public void CalcularPercentualSalarioBaixo()
        {
            if(Salario <= 150)
            {
                qtd = qtd + 1;
            }

            pecSal = (4 / 100) * qtd;
        }

    }
}
