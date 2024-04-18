/*
Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o 
X, se for o caso.
*/

using System;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Digite o valor: ");
            number = int.Parse(Console.ReadLine());

            for(int i = 0; i <= number; i++)
            {
                
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}