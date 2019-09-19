using System;

namespace empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            int salario = 0;

            
            Console.WriteLine ("insira o valor do seu salário");
            salario = int.Parse(Console.ReadLine());

            if(salario < 500)
            {
                Console.WriteLine("Parabéns o seu salário foi aumentado em 30%!");
                Console.WriteLine("teve um aumento de: " + (salario * 0.3));
                Console.WriteLine("Agora o seu salário é de: "+(salario * 1.3));
            }

            else{
                Console.WriteLine("Desculpe, seu orçamento foi recusado");
            }
        }
    }
}

           
