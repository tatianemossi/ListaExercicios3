using System;

namespace exercicio4.ConsoleApp
{
    internal class Program
    {
        /*
         Exercício 4: 
        • Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N.
        • Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N = 10N.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 10: ");
            var n = Convert.ToInt32(Console.ReadLine());
            if (n > 10)
            {
                Console.WriteLine("O número informado é maior que 10");
            }                
            else
            {
                for (int i = 0; i <= 10; i++)
                    Console.WriteLine($"{i} X {n} = {n * i}");
            }
            Console.ReadLine();
        }
    }
}
