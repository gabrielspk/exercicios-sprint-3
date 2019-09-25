using System;

namespace matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num0 = 0;
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            
            Console.Write("digite o primeiro número");
            num0 = int.Parse(Console.ReadLine());
            
            int[] vetor = new int[6];

            int[] vetor2 = {num0,num1,num2,num3,num4,num5};

            if (num0 % 2 == 0)
            Console.WriteLine("É par");
        else
            Console.WriteLine("é impar");

            if (num1 % 2 == 0)
            Console.WriteLine("É par");
        else
            Console.WriteLine("é impar");

            if (num2 % 2 == 0)
             Console.WriteLine("É par");
        else
            Console.WriteLine("é impar");

            if (num3 % 2 == 0)
             Console.WriteLine("é par");
        else
            Console.WriteLine("é impar");

            if (num4 % 2 == 0)
            Console.WriteLine("é par");
        else
            Console.WriteLine("é impar");

            if (num5 % 2 == 0)
            Console.WriteLine("é par");
        else
            Console.WriteLine("é impar");

            


        }
    }
}
