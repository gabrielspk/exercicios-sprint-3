using System;

namespace Multiplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um número e diremos se é multiplo de 3 ou não");
            int Num = int.Parse(Console.ReadLine());

            if(Num % 3 == 0){
                System.Console.WriteLine("O número é multiplo por 3");
            } else {
                System.Console.WriteLine("O número não é multiplo por 3");
            }
        }
    }
}
