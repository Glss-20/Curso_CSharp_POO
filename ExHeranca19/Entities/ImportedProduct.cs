using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca19.Entities
{
    class ImportedProduct : Product
    {
        public double ImportRate { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(String name, double price, double importRate) 
            : base(name, price)
        {
            ImportRate = importRate;
        }

        public double TotalPrice()
        {
            return Price + ImportRate;
        }

        public override void PriceTag()
        {
            Console.WriteLine($"{Name} - R${TotalPrice()} (Rate: {ImportRate})");     
        }


    }
}
