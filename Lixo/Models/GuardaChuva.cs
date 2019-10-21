using System;
using Lixo.Interface;

namespace Lixo.Models
{
    public class GuardaChuva:IReciclar
    {
        public bool JogarLixo()
        {
            System.Console.WriteLine("Guarda Chuvas devem ser jogadas nos lixos de cor Cinza");
            return true;
        }
    }
}