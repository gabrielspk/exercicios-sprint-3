using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;
            double altura;

            System.Console.WriteLine("Digite o seu nome: ");
            string Nome = (Console.ReadLine());
            
            System.Console.WriteLine("Digite o seu peso");
            peso = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a sua altura");
            altura = double.Parse(Console.ReadLine());

            double Imc = peso / (altura * altura);

            if(Imc < 20){
                System.Console.WriteLine($"Paciente {Nome}");
                System.Console.WriteLine("Abaixo do peso");
            }else if (Imc < 25){
                System.Console.WriteLine($"Paciente {Nome}");
                System.Console.WriteLine("Normal");
            }else if (Imc < 30){
                System.Console.WriteLine($"Paciente {Nome}");
                System.Console.WriteLine("Excesso de peso");
            }else if (Imc < 35){
                System.Console.WriteLine($"paciente {Nome}");
                System.Console.WriteLine("Obesidade");
            }else if (Imc > 35){
                System.Console.WriteLine($"pacinete {Nome}");
                System.Console.WriteLine("Obesidade Mórbida");
            }
            
        }
    }
}
