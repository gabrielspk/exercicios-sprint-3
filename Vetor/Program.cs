using System;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            

            System.Console.WriteLine("Digite o Número de inteiros que deseja");
            int n = int.Parse(Console.ReadLine());

            int[] vetor = new int[n];
            for(int i = 0; i < n; i++){
                vetor[i] = i;
            }
        }
    }
}
