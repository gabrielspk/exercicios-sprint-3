using System;

namespace PesoTerra
{
    class Program
    {
        static void Main(string[] args)
        {   
            double Peso;
            double Planeta;
            double Gravidade;
            string OpcaoPlaneta;
            

            System.Console.WriteLine("Digite o seu peso");
            Peso = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite um planeta para calcularmos:");
            System.Console.WriteLine("1 - Mercúrio");
            System.Console.WriteLine("2 - Vênus");
            System.Console.WriteLine("3 - Marte");
            System.Console.WriteLine("4 - Júpiter");
            System.Console.WriteLine("5 - Saturno");
            System.Console.WriteLine("6 - Urano");
            OpcaoPlaneta = Console.ReadLine();
            
            switch (OpcaoPlaneta){
                case "1":
                Planeta = Peso * 0.37;
                System.Console.WriteLine("O seu peso de mercúrio seria " + Planeta);
                break;

                case "2":
                Planeta = Peso * 0.88;
                System.Console.WriteLine("O seu peso de Vênus seria " + Planeta);
                break;

                case "3":
                Planeta = Peso * 0.38;
                System.Console.WriteLine("O seu peso de Marte seria " + Planeta);
                break;

                case "4":
                Planeta = Peso * 2.64;
                System.Console.WriteLine("O seu peso de Júpiter seria " + Planeta);
                break;

                case "5":
                Planeta = Peso * 1.5;
                System.Console.WriteLine("O seu peso de Saturno seria " + Planeta);
                break;

                case "6":
                Planeta = Peso * 1.17;
                System.Console.WriteLine("O seu peso de Urano seria " + Planeta);
                break;
            }
        }
    }
}
