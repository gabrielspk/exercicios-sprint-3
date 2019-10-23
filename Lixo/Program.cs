using System;
using System.Collections.Generic;
using Lixo.Interface;
using Lixo.Models;

namespace Lixo
{


enum ObjetosEnum : int
{
    Garrafa,
    GarrafaPET,
    GuardaChuva,
    Latinha,
    Papelao,
    PoteManteiga,
};

enum CategoriaEnum : int
{
    IReciclar
};

    class Program
    {
        static void Main(string[] args)
        {
        
            
            System.Console.WriteLine("Jogue fora o seu lixo no local correto");
            System.Console.WriteLine();
            System.Console.WriteLine("Garrafa");
            System.Console.WriteLine("GarrafaPET");
            System.Console.WriteLine("GuardaChuva");
            System.Console.WriteLine("Latinha");
            System.Console.WriteLine("Papelao");
            System.Console.WriteLine("PoteManteiga");
            int opcao =  int.Parse(Console.ReadLine());


            switch (opcao) {
                case 1:
                Garrafa garrafa = new Garrafa (); 
                break;

                case 2:
                GarrafaPet garrafaPet = new GarrafaPet ();
                break;

                case 3:
                GuardaChuva guardaChuva = new GuardaChuva ();
                break;

                case 4:
                Latinha latinha = new Latinha ();
                break;

                case 5:
                Papelao papelao = new Papelao ();
                break;

                case 6:
                PoteManteiga poteManteiga = new PoteManteiga ();
                break;


                
            }

        }
    }
}
