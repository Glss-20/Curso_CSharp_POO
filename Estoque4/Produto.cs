using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEstoque
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotal()
        {
            double total = Preco * Quantidade; 
            return total;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Dados do produto: Nome - {Nome}; Preço R${Preco}; Quantidade {Quantidade}; Total: {ValorTotal()}");

        }

        public void AdicionarProdutos()
        {
            Console.Write("Quantos produtos adicionar: ");    
            int quantidade = int.Parse( Console.ReadLine());
            Quantidade += quantidade;

            Console.WriteLine($"Dados atualizado:");
            ExibirDados();
        }

        public void RemoverProdutos()
        {
            Console.Write("Quantos produtos remover: ");
            int quantidade = int.Parse(Console.ReadLine());
            Quantidade -= quantidade;

            Console.WriteLine($"Dados atualizado:");
            ExibirDados();
        }
    }
}
