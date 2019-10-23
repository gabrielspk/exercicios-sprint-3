using System;

namespace BaseEAltura
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Area do Retangulo */
            System.Console.WriteLine("Entre com a base do retangulo");
            double Base = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Entre com altura do retangulo");
            double Altura = double.Parse(Console.ReadLine());
            double areaRet = Base * Altura;
            System.Console.WriteLine("A área do retangulo é " + areaRet);
            
            //*Perimetro do Retangulo */
            double Perimetro =  Base * 2 + Altura * 2;
            System.Console.WriteLine("O perimetro do retangulo é " + Perimetro);

            //*Diagonal do Retangulo */
            System.Console.WriteLine($"A Diagonal do Retangulo é " + Math.Sqrt((Base * Base) + (Altura * Altura)));

        }
    }
}
        




            

