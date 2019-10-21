using System;
using Lixo.Interface;

namespace Lixo.Models
{
    public class Latinha:IReciclar
    {
        public bool JogarLixo()
        {
            System.Console.WriteLine("Latinhas devem ser jogadas nos lixos de cor Amarela");
            return true;
        }
    }
}