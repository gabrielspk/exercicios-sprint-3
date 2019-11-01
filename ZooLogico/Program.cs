using System;

namespace ZooLogico
{
    class Program
    {
        static void Main(string[] args)
        {
            string EscolhaAnimal;
            
            System.Console.WriteLine("Bem vindo ao ZooLógico");

            System.Console.WriteLine("Digite o número do animal desejado");

            System.Console.WriteLine("1 - Tubarão Martelo");
            System.Console.WriteLine("2 - Tucano");
            System.Console.WriteLine("3 - Arara");
            System.Console.WriteLine("4 - Leão");
            System.Console.WriteLine("5 - Orangotango");
            System.Console.WriteLine("6 - Chimpanzé");
            System.Console.WriteLine("7 - Pinguim");
            System.Console.WriteLine("8 - Tartagura");
            System.Console.WriteLine("9 - Golfinho");
            EscolhaAnimal = Console.ReadLine();

            switch (EscolhaAnimal){
                
                case "1":
                System.Console.WriteLine("Aquário");
                break;

                case "2": 
                System.Console.WriteLine("Gaiola");
                break;

                case "3":
                System.Console.WriteLine("Gaiola");
                break;

                case "4":
                System.Console.WriteLine("Pasto");
                break;

                case "5":
                System.Console.WriteLine("Casa em árvore");
                break;

                case "6":
                System.Console.WriteLine("Casa em árvore");
                break;

                case "7":
                System.Console.WriteLine("Piscina Gelada");
                break;

                case "8":
                System.Console.WriteLine("Aquario");
                break;

                case "9":
                System.Console.WriteLine("Piscina");
                break;
            }
        }
    }
}
