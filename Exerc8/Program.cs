using System;
using System.Globalization;

namespace Exerc8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para calcular quanto será pago por um produto sendo que o preço e o desconto são fornecidos pelo usuário.
            //Exemplo:
            //Preço do produto: 67.00(preço informado pelo usuário)
            //Percentual de desconto:	25.00(percentual informado pelo usuário)
            //Valor a ser pago:		50.25(valor calculado e exibido pelo algoritmo)

            double prod, desc;

            Console.Write("Preço do produto: ");
            prod = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Percentual de desconto: ");
            desc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            desc = (desc / 100) * prod;
            prod -= desc;

            Console.WriteLine("Valor a ser pago: R$" + prod.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}