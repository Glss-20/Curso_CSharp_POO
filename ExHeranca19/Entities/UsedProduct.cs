using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca19.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate {  get; set; }

        public UsedProduct() { }

        public UsedProduct(String name, double price, DateTime manufactureDate) 
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }
        public override void PriceTag()
        {
            Console.WriteLine($"{Name} (used) - R${Price} (Manufacture date: {ManufactureDate})");
        }

    }
}
