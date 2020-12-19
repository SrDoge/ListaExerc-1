using System;

namespace Exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para calcular a idade de uma pessoa sendo que o ano atual 
            //e o ano de nascimento são fornecidos pelo usuário. Apresente a idade depois de calculada.
            //Exemplo:
            //            Ano atual:		2009(ano fornecido pelo usuário)
            //Ano de nascimento: 1967(ano fornecido pelo usuário)
            //Idade: 42(idade calculada e exibida pelo algoritmo)

            Console.Write("Informe apenas o ano atual: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Informe somente o ano de nascimento: ");
            int anoNasc = int.Parse(Console.ReadLine());

            Console.WriteLine("O usuário tem " + (ano - anoNasc) + " anos.");
        }
    }
}
