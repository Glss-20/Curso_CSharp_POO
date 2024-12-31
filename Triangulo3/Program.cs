using System.Security.Cryptography;

namespace ExTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Medidas do triangulo X: ");
            Console.Write("Lado A: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("Lado B: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("Lado C: ");
            double c1 = double.Parse(Console.ReadLine());
            Triangulo x = new Triangulo(a1, b1, c1);

            Console.WriteLine("Medidas do triangulo y: ");
            Console.Write("Lado A: ");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("Lado B: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("Lado C: ");
            double c2 = double.Parse(Console.ReadLine());
            Triangulo y = new Triangulo(a2, b2, c2);

            double areaX = x.Area(x.A, x.B, x.C);
            double areaY = y.Area(y.A, y.B, y.C);

            Console.WriteLine($"Area triângulo X:{areaX}");
            Console.WriteLine($"Area triângulo Y:{areaY}");

        }
    }
}
