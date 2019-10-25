using System;

namespace OrdemAlfabetica {
    class Program {
        static void Main (string[] args) {
            
        

            System.Console.WriteLine("Digite o primeiro nome");
            string Nome1 = (Console.ReadLine());
            System.Console.WriteLine("Digite o segundo nome");
            string Nome2 = (Console.ReadLine());

            int Compare = string.Compare(Nome1,Nome2);

            if (Compare <= 0)
            {
                System.Console.WriteLine($"Primeiro {Nome1} segundo {Nome2}");
            }else{
                System.Console.WriteLine($"Primeiro {Nome2} segundo {Nome1}");
            }
        }

    }
}