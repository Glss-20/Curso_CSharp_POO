using System.ComponentModel;
using System.Collections.Generic;

namespace Delegate36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DELEGATE PREDICATE - Representa um método que retorna um booleano e recebe um argumento genérico.
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 300));
            list.Add(new Product("Mouse", 50));
            list.Add(new Product("Tablet", 350));
            list.Add(new Product("HD Case", 80));

            // 1ª forma de usar um Delegate Predicate
            // RemoveAll é um método que recebe um Predicate<Product>.
            // A expressão lambda "p => p.Price >= 200" é usada como argumento do Predicate.
            // Ele remove todos os produtos cujo preço seja maior ou igual a 200.
            list.RemoveAll(p => p.Price >= 200);

            // 2ª forma de usar um Delegate Predicate
            // RemoveAll percorre cada item da lista e chama o método auxiliar `ProductTest` para decidir
            // se o item será removido (retorno `true`) ou mantido (retorno `false`).
            list.RemoveAll(ProductTest);

            // Itera sobre os elementos restantes na lista e os imprime no console.
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        // Método auxiliar que implementa o Predicate<Product>.
        // Retorna `true` se o preço do produto for maior ou igual a 200, indicando que o produto deve ser removido.
        public static bool ProductTest(Product p)
        {
            return p.Price >= 200;
        }
    }
}
