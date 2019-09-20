using System;

namespace impar0a100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Os números de 1 a 100 impares são: ");
            
            for(int i=1; i < 100; i+=2){
            Console.WriteLine(i);
            }
        }
    }
}
