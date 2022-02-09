using System;

namespace exercicio5.ConsoleApp
{
    internal class Program
    {
        /*
        Exercício 5: 
        • Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de 
        A! e o seu resultado. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
        • Pesquise sobre “fatorial” 
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite o fatorial: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int resultado = 1;
            string contaFatorial = "";
            var fatorialInicial = a;

            while (a != 1)
            {
                contaFatorial = $"{contaFatorial} {a} X";
                resultado = resultado * a;
                a = a - 1;                
            }
            Console.WriteLine($"{fatorialInicial}! = {contaFatorial} 1 = {resultado}");
            Console.ReadLine();
        }
    }
}
