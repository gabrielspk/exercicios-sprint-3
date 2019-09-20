using System;

namespace Impar
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1 = 0;
          
        do{

           Console.WriteLine("digite o primeiro número");
           num1 = int.Parse(Console.ReadLine());
          
            if (num1 % 2==0){
            Console.WriteLine("O número digitado é par");
            }else{
            Console.WriteLine("O número digitado é impar");
            }

            } while(num1 !=0);
           }
        }
    }

