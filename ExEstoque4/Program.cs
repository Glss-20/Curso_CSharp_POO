namespace ExEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fazer um menu

            Produto p1 = new Produto();
            
            Console.WriteLine("Dados do produto: ");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p1.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p1.Quantidade = int.Parse(Console.ReadLine());

            p1.ExibirDados();

            p1.AdicionarProdutos();

            p1.RemoverProdutos();
        }
    }
}
