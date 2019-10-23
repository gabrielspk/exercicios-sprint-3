using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe os graus Celsius");
            double Celsius = double.Parse(Console.ReadLine());

            double Resultado = Celsius * 9/5 + 32;

            System.Console.WriteLine("O valor convertido de graus celsius para fahreinhet é " + Resultado);
        }
    }
}
