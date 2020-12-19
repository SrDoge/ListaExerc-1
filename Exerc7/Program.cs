using System;
using System.Globalization;

namespace Exerc7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para calcular o percentual de desconto que foi dado em um determinado produto sendo que  o usuário deverá informar o valor sem desconto e depois o valor com desconto.
            //Exemplo:
            //Valor sem desconto: 350.00(valor informado pelo usuário)

            //Valor com desconto: 315.00(valor informado pelo usuário)
            //Percentual de desconto: 10.00(perímetro calculada e exibida pelo algoritmo)

            double vSem, vCom;

            Console.Write("Valor sem desconto: ");
            vSem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor com desconto: ");
            vCom = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            vSem = (vSem - vCom) / vSem;
            vSem *= 100;

            Console.WriteLine("O percentual de desconto é de " + vSem.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}
