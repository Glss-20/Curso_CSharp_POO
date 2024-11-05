using System;


namespace ExRetangulo
{
	public class Retangulo
	{
		public double Largura;
		public double Altura;

		public void CadastrarRetangulo()
		{
			Console.WriteLine("Digite a altura e largura do retangulo: ");
			Console.Write("Altura: ");
			Altura = double.Parse(Console.ReadLine());

            Console.Write("Largura: ");
			Largura = double.Parse(Console.ReadLine());
		}

		public void Area()
		{
            Console.WriteLine($"Área do retângulo: {Altura * Largura}");
        }

        public void Perimetro()
        {
            Console.WriteLine($"Perímetro do retângulo: {(Altura + Largura) * 2}");
        }

        public void Diagonal()
        {
			Console.WriteLine($"Diagonal do retângulo: {Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2))}");
        }
    }
}