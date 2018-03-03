using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*6. Ler o salário fixo e o valor das vendas efetuadas pelo vendedor de uma empresa.Sabendose
que ele recebe uma comissão de 3% sobre o total das vendas até R$1.500,00 mais 5%
sobre o que ultrapassar este valor, calcular e escrever o seu salário total. */

namespace Ex_6
{
    class Salario
    {
        public decimal SalarioFixo { get; set; }
        public decimal ValorVendas { get; set; }
        
        public void CalcularSalario()
        {
            decimal salarioFinal =0;
            decimal calc =0;

            if (ValorVendas <= 1500)
            {
                salarioFinal = SalarioFixo +  (ValorVendas * 0.03m);
                Console.Write("Salario final: " + salarioFinal);
               
             }
            else
            {
                 calc = (1500 * 0.03m);
                 salarioFinal = SalarioFixo + calc +(ValorVendas * 0.05m);
                 Console.Write("Salario final: " + salarioFinal);

            }


           
        }
    }
}
