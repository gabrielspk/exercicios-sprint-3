using System;

namespace corrigido
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            Console.Write("entre com a primeira nota: ");
            nota1= double.Parse(Console.ReadLine());
            Console.Write("Entre com a segunda nota: ");
            nota2= double.Parse(Console.ReadLine());
            Console.Write("Entre com a terceira nota: ");
            nota3= double.Parse(Console.ReadLine());
            Console.Write("Entre com a quarta nota: ");
            nota4= double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("sua média é :" + media);
        }
    }
}
