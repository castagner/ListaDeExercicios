using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*s. Escrever um algoritmo que leia o número de carros por ele
vendidos, o valor total de suas vendas, o salário fixo e o valor que ele recebe por carro
vendido. Calcule e escreva o salário final do vendedor.*/


namespace Exercicio_4
{
    class Salario
    {
        public Decimal CarrosVendido { get; set; }
        public Decimal TotalVendas { get; set; }
        public Decimal SalarioFixo { get; set; }
        public Decimal ComCarro { get; set; }


        public Decimal CalcularSalarioFinal()
        {
            Decimal total = SalarioFixo+ (TotalVendas * 0.05m) + (CarrosVendido *ComCarro);

            return total;
            
        }
    }
}
