using System;

namespace Notas
{
    class Program
    {
        private const int V = 4;

        static void Main(string[] args)
        {
            int num1= 0;
            int num2= 0;
            int num3= 0;
            int num4= 0;
            string oper;
            double media = 8;

            Console.WriteLine("Digite a nota do 1 Bimestre");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do 2 Bimestre");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do 3 Bimestre");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota do 4 Bimestre");
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o operador:");
            oper = Console.ReadLine();

            Console.WriteLine($"{num1} + {num2} + {num3} + {num4} = {(num1 + num2 + num3 + num4) / 4 }");

            Console.WriteLine("Sua média é " + media);

            if (media >=8)
            {
                Console.WriteLine("Você passou!");
                Console.WriteLine("Parabéns sua nota esta a cima da media"); }
            else if(media == 7){
                Console.WriteLine("Você passou");
                Console.WriteLine("Voce esta na media");
            }else if(media ==6){
                Console.WriteLine("Você reprovou");
                Console.WriteLine("Se esforce mais na proxima vez");
            }

       
               }
            }
        }
    


