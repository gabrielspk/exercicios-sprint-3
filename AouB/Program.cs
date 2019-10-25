using System;

namespace AouB
{
    class Program
    {
        static void Main(string[] args)
        {
            int A ;
            int B ;

            System.Console.WriteLine("Digite o número A");
            A = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o número B");
            B = int.Parse(Console.ReadLine());
            
            A += B;
            B = A - B;
            A -= B;
            
            System.Console.WriteLine($"O valor do A é {A} e o valor do B é {B}");
            
        }
    }
}
