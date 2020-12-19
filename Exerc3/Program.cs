using System;
using System.Globalization;

namespace Exerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para calcular o valor total gasto em livros por uma turma do curso de advocacia no primeiro ano de faculdade.
            //Sabendo que no primeiro ano esta turma deverá comprar quatro livros.O usuário deverá informar  o valor de cada livro e o número de alunos da turma.
            //Exemplo:
            //Valor do livro 1:	195.55(valor informado pelo usuário)
            //Valor do livro 2:	255.00(valor informado pelo usuário)
            //Valor do livro 3:	127.22(valor informado pelo usuário)
            //Valor do livro 4:	98.58(valor informado pelo usuário)
            //Número de alunos da turma: 48(número informado pelo usuário)
            //Valor total gasto pela turma: 32.464,80(valor calculado e exibido pelo algoritmo)

            double[] livros = new double[4];
            double gastos = 0;

            for (int i = 0; i < livros.Length; i++)
            {
                Console.Write("Valor do " + (i + 1) + "º livro: ");
                livros[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                gastos += livros[i];
            }

            Console.Write("Quantidade de alunos na turma: ");
            int turma = int.Parse(Console.ReadLine());

            double total = gastos * turma;
            Console.WriteLine(string.Format("{0:N}", total));
        }
    }
}
