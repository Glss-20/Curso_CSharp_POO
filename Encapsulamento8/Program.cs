namespace ExEncapsulamento8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("TV", 1300, 10);

            //USANDO AUTO-PROPERTIES

            //É a mesma lógica do PROPERTIE, o AUTO-PROPERTIE é uma melhora do PROPERTIE, deixa a classe melhor.
            
            //USANDO PROPRIEDADES

            p1.Nome = "TV 50 Polegadas";

            Console.WriteLine(p1.Nome);
           

            //USANDO GET E SET
            /*
            p1.SetNome("TV 50 Polegadas");

            Console.WriteLine(p1.GetNome());
            Console.WriteLine(p1.GetPreco());
            Console.WriteLine(p1.GetQuantidade());
            */
        }
    }
}
