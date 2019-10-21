using System;
using Lixo.Interface;

namespace Lixo.Models
{
    public class Garrafa:IReciclar
    {
        public bool JogarLixo()
        {
            System.Console.WriteLine("Você deve jogar garrafas no lixo de cor verde");
            return true;
        }
    }
}