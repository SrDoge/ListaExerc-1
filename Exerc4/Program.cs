using System;
using System.Globalization;

namespace Exerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para calcular o volume de uma esfera. O raio da esfera será fornecido pelo usuário. Apresentar o volume depois de calculado.
            //Fórmula: Volume = 3.14 * R ^ 2
            //Exemplo:
            //Raio de esfera: 15.30(raio fornecido pelo usuário)

            //Volume: 735.04(volume calculado e exibido pelo algoritmo)

            double pi = 3.14;

            Console.Write("Raio de esfera: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double vol = pi * Math.Pow(raio, 2);
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
