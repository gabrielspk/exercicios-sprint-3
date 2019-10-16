using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class Teclado : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando Solo Teclado");
            return true;
        }
        
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocar acordes do Teclado");
            return true;
        }
    }
}