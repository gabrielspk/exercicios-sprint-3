using System;

namespace NumTri {
    class Program {
        static void Main (string[] args) {

            int Num1;
            int Num2;
            int Num3;

            System.Console.WriteLine("Digite o 1º número");
            Num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o 2º número");
            Num2 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o 3º número");
            Num3 = int.Parse(Console.ReadLine());

            if(Num1 == Num2 && Num1 == Num3 && Num2 == Num3){
                System.Console.WriteLine("Isto é um triangulo");
            } else {
                System.Console.WriteLine("Isto não é um triangulo");
            }


        }

    }
}
