using System;

namespace Meses
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            System.Console.WriteLine("Digite um número de 1 a 12");
            int OpcaoMes = int.Parse(Console.ReadLine());
            
            if (OpcaoMes < 13){


            switch (OpcaoMes){
                case 1:
                System.Console.WriteLine("O mês é de Janeiro");
                break;
                
                case 2:
                System.Console.WriteLine("O mês é de Fevereiro");
                break;

                case 3:
                System.Console.WriteLine("O mês é de Março");
                break;

                case 4:
                System.Console.WriteLine("O mês é de Abril");
                break;

                case 5:
                System.Console.WriteLine("O mês é de Maio");
                break;

                case 6:
                System.Console.WriteLine("O mês é de Junho");
                break;

                case 7:
                System.Console.WriteLine("O mês é de Julho");
                break;

                case 8:
                System.Console.WriteLine("O mês é de Agosto");
                break;

                case 9:
                System.Console.WriteLine("O mês é de Setembro");
                break;

                case 10:
                System.Console.WriteLine("o mês é de Outubro");
                break;

                case 11:
                System.Console.WriteLine("O mês é de Novembro");
                break;

                case 12:
                System.Console.WriteLine("O mês é de Dezembro");
                break;
            }
            }else{
                System.Console.WriteLine("erro");
            }
            
        }
    }
}
