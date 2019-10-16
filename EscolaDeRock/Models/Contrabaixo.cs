using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Contrabaixo : InstrumentoMusical, Ipercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do contrabaixo");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do contrabaixo.");
            return true;
        }
    }
}