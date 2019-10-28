using System;

namespace VerboInf
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Escreva um verbo: ");
            var Verbo = (Console.ReadLine());

            if(Verbo.EndsWith("ar"))
            {
                System.Console.WriteLine("Verbo da 1 conjugação");
            } else if (Verbo.EndsWith("er")){
                System.Console.WriteLine("Verbo da 2 conjugação");
            }else if (Verbo.EndsWith("ir")){
                System.Console.WriteLine("Verbo da 3 conjugação");
            }else {
                System.Console.WriteLine("Não é verbo");
            }
        }
    }
}
