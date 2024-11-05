using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca19.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        List<Product> list = new List<Product>();

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void RegisteProducts()
        {
            Console.Write("Enter the number of products: ");
            int quant = int.Parse(Console.ReadLine());

            int cont = 0;
            while (cont < quant)
            {
                Console.WriteLine($"Product {cont + 1}#: ");
                Console.Write("Type common, used or imoport(c/u/i): ");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (type == "u" || type == "U")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else if (type == "i" || type == "I")
                {
                    Console.Write("Rate import: ");
                    double rate = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, rate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
                cont++;
            }
        }

        public void ShowPriceTags()
        {
            Console.WriteLine();
            int cont1 = 0;
            Console.WriteLine("PRICE TAGS");
            foreach (Product p in list)
            {
                Console.Write($"{cont1+1}# - ");
                p.PriceTag();
                cont1++;
            }
        }

        public virtual void PriceTag()
        {
            Console.WriteLine($"{Name} - R${Price}");
        }
    }
}
