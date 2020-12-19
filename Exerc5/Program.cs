using System;
using System.Globalization;

namespace Exerc5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para calcular a área de uma sala sendo que os comprimentos das paredes são fornecidos pelo usuário em metros. Apresente a área depois de calculada.
            //Exemplo:
            //Comprimento parede 1:	15.00(comprimento fornecido pelo usuário)
            //Comprimento parede 2:	10.00(comprimento fornecido pelo usuário)

            //Área da sala: 150(área calculada e exibida pelo algoritmo)

            double[] paredes = new double[2];
            double A = 1;

            for (int i = 0; i < paredes.Length; i++)
            {
                Console.Write("Comprimento da " + (i + 1) + "º parede: ");
                paredes[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                A *= paredes[i];
            }

            Console.WriteLine("Área da sala é de " + A.ToString("F2", CultureInfo.InvariantCulture) + " metros.");
        }
    }
}
