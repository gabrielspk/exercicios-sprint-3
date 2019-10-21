using System;
using Lixo.Interface;

namespace Lixo.Models
{
    public class Papelao:IReciclar
    {
        public bool JogarLixo()
        {
            System.Console.WriteLine("Papelões devem ser jogados no lixo de cor Azul");
            return true;
        }
    }
}