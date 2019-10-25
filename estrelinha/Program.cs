using System;

namespace estrelinha
{
    class Program
    {
        static void Main(string[] args)
        {
            int Altura = 0;
            string ast = "*";
            string ast2 = "*";
            
            System.Console.WriteLine("Digite a altura do triangulo");
            Altura = int.Parse(Console.ReadLine());

            while (Altura !=0)
            {
                for (int i = Altura ; i != 0 ; i--)
                {
                    Console.Write(ast2);
                    ast2 = (ast = "*");
                }

                    Altura --;

                    System.Console.WriteLine(); 

                    
            }
        }
    }
}
