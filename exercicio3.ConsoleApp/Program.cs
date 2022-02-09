using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio3.ConsoleApp
{
    internal class Program
    {
        /*
          Exercício 3: 
        • Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e 
        que se encontram no conjunto dos números de 1 até 500.
        */
        static void Main(string[] args)
        {
            var resultado = 0;
            for (int numero = 1; numero <= 500; numero++)
            { 
                if (numero % 2 == 1 && numero % 3 == 0)
                    resultado = resultado + numero;
            }
                        
            Console.WriteLine($"O resultado é: {resultado}");
            Console.ReadLine();
        }
    }
}
