using System;
using System.Linq;

namespace listaExercicios3.ConsoleApp
{
    internal class Program
    {
        /*
         Exercício 1: 
        • Desenvolver um algoritmo que leia a altura de 15 pessoas. Este programa deverá calcular e mostrar:
        a. A menor altura do grupo;
        b. A maior altura do grupo;
        */
        static void Main(string[] args)
        {
            decimal[] listaAltura = new decimal[15];

            for (int contador = 0; contador < 15; contador++)
            { 
                Console.WriteLine("Digite a sua altura: ");
                var altura = Convert.ToDecimal(Console.ReadLine());
                listaAltura[contador] = altura;
            }
            listaAltura = listaAltura.OrderBy(c => c).ToArray();                

            Console.WriteLine($"Menor: {listaAltura[0]}");
            Console.WriteLine($"Maior: {listaAltura[14]}");

            Console.ReadLine();
            
        }
    }
}
