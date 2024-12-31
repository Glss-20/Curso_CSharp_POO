using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExEnumAndComposition16.Entities;
using ExEnumAndComposition16.Entities.Enum;

namespace ExEnumAndComposition16
{
    public class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();

            order1.RegisterClient();

            order1.RegisterOrder();

            order1.DisplayData();
        }
    }
}
