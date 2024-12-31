using System;
using System.Collections.Generic;

namespace Delegate37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DELEGATE ACTION - Não retorna um valor específico.
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 300));
            list.Add(new Product("Mouse", 50));
            list.Add(new Product("Tablet", 350));
            list.Add(new Product("HD Case", 80));
            
            list.ForEach(UpdatePrice); // O método atualiza o valor do Price do Product.s
            // No lugar de "UpdatePrice" poderiamos passar uma função lambda ao invés de chamar um método.
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

        }
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

    }
}
