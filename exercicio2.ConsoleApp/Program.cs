using System;

namespace exercicio2.ConsoleApp
{
    internal class Program
    {
        /*
        Exercício 2: 
        • Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
        */
        static void Main(string[] args)
        {
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);                    
                }                
            }
            Console.ReadLine();
        }
    }
}
