using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExGenerics29
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + " - " + Price;
        }

        public int CompareTo(object obj) 
        // O método CompareTo é implementado para comparar objetos, retornando um valor que indica a ordem entre eles.
        {
            // Verifica se o objeto passado no parametro é do tipo "Product".
            if (!(obj is Product))
            {
                // Se obj não for um "Product", lança uma exceção "ArgumentException".
                throw new ArgumentException("Error");
            }

            // Converte obj para o tipo "Product" e armazena na variável other.
            Product other = obj as Product;

            // Compara o preço do produto atual (Price) com o preço do produto "other".
            // Retorna:
            // - Um valor menor que 0 se Price for menor que other.Price.
            // - 0 se ambos forem iguais.
            // - Um valor maior que 0 se Price for maior que other.Price.
            return Price.CompareTo(other.Price);
        }
    }
}
