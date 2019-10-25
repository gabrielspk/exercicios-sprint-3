using System;

namespace VerboInf
{
    class Program
    {
        static void Main(string[] args)
        {
            string Verbo;
            
            System.Console.WriteLine("Entre com um verbo no infinitivo");
            Verbo = Console.ReadLine();

            if (Verbo != "ar" && Verbo != "er" && Verbo != "ir")
            {
                System.Console.WriteLine("O verbo está no infinitivo");
            } else {
            System.Console.WriteLine("O verbo não está no infinitivo");
            }
        }
    }
}
