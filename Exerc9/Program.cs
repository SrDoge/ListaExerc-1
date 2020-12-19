using System;
using System.Globalization;

namespace Exerc9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que calcule o valor em reais correspondentes aos dólares que um turista possui. O programa deve solicitar a quantidade de dólares e sua cotação naquele dia.
            //Exemplo:
            //Quantidade de dólares: 100.00(quantidade informada pelo usuário)
            //Cotação do dólar no dia:	2.60(cotação informada pelo usuário)
            //Valor em reais: 260.00(valor calculado e exibido pelo algoritmo)

            decimal dolar, cot;

            Console.Write("Quantidade de dólares: ");
            dolar = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Cotação atual do dólar: ");
            cot = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            dolar *= cot;

            Console.WriteLine("Valor em Reais: " + dolar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
