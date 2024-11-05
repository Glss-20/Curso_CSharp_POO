using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExEnumAndComposition16.Entities
{
    public class Product // QUAL O SENTIDO DESSA CLASSE ELIO????
    {  
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
