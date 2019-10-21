using System;
using Lixo.Interface;

namespace Lixo.Models
{
    public class GarrafaPet:IReciclar
    {
        public bool JogarLixo()
        {
            System.Console.WriteLine("Você deve jogar garrafasPETS no lixo de cor vermelha");
            return true;
        }
    }
}