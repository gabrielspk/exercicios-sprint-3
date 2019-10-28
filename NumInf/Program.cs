using System;

namespace NumInf
{
    class Program
    {
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Digite um número");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i +=2){
                System.Console.WriteLine();
                Console.Write(i);
            }
        }
    }
}
