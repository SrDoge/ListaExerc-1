using System;

namespace Exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que calcula a quantidade de cadeiras necessárias para preencher um restaurante. 
            //O usuário devera informar o número de cadeiras por mesa e o número de mesas.
            //Exemplo:
            //Número de cadeiras por mesa: 4(número informado pelo usuário)
            //Número de mesas: 10(número informada pelo usuário)
            //Números de cadeiras necessárias:	40(número calculado e exibido pelo algoritmo)

            Console.Write("Quantidade de cadeiras por mesa: ");
            int cad = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de mesas: ");
            int mesa = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade de cadeiras necessárias: " + (cad * mesa));
        }
    }
}
