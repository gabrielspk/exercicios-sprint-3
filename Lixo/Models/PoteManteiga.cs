using System;
using Lixo.Interface;

namespace Lixo.Models
{
    public class PoteManteiga:IReciclar
    {
        public bool JogarLixo()
        {
            System.Console.WriteLine("Potes de manteigas devem ser jogados nos lixos de cor Marrom");
            return true;
        }
    }
}