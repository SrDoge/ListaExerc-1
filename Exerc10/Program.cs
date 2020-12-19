using System;
using System.Globalization;

namespace Exerc10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que calcule a quantidade de litros de cerveja necessária para uma festa.O usuário deverá informar:
            //•	O número de pessoas que comparecerão a esta festa
            //•	A quantidade média em litros de cerveja que uma pessoa consome em uma hora
            //•	Número de horas que a festa irá durar
            //Exemplo:
            //Número de pessoas: 10(informado pelo usuário)

            //Qtde média de consumo por pessoa por hora:	0.5(informado pelo usuário)
            //Duração da festa em horas: 9(informado pelo usuário)
            //Litros de cerveja necessários:			45(calculado e exibido pelo algoritmo)

            Console.Write("Número de pessoas: ");
            int numP = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Média de consumo por pessoa por hora: ");
            double mediaH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Duração da festa em horas: ");
            int hora = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double litroT = (numP * mediaH) * hora;

            Console.WriteLine("Litros de cerveja necessários: " + litroT.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
