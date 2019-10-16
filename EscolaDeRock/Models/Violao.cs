using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    class Violao : InstrumentoMusical, IHarmonia, IMelodia, Ipercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do violão.");
            return true;
        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocar acordes de violão.");
            return true;
        }
        public bool TocarSolo()
        {
            System.Console.WriteLine("tocando solo do violão.");
            return true;
        }
    }
}