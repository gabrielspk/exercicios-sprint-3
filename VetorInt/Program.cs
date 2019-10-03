using System;

namespace VetorInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Digite a quantidade de numeros requeridos.");
            int n = int.Parse(Console.ReadLine());

            int[] numeros = new int [n];


            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"Digite o {i + 1}:");
                numeros
            }
        }
    }
}
