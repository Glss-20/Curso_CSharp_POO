using System.Security.Cryptography;

namespace ExRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Retangulo r1 = new Retangulo();
           r1.CadastrarRetangulo();

            r1.Area();
            r1.Perimetro();
            r1.Diagonal();

           
           Console.ReadLine();
        }
    }
}
