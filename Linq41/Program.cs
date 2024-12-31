using Linq41.Entities;
using System;

namespace Linq41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1]);
                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty().Average();
            Console.WriteLine("Average price = " + avg.ToString());


            Console.WriteLine("Products with price less than average");
            var names = list.Where(p => p.Price <= avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string p in names)
            {
                Console.WriteLine(p);
            }
        }
    }
}
