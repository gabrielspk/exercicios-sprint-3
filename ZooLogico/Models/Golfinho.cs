using ZooLogico.Interfaces;

namespace ZooLogico.Models
{
    public class Golfinho : IBranquiado
    {
        public bool aquario()
        {
            System.Console.WriteLine("Esse animal vai para o aquario");
            return true;
        }
    }
}