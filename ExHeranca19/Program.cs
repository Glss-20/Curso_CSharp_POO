using ExHeranca19.Entities;

namespace ExHeranca19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            
            p1.RegisteProducts();
            p1.ShowPriceTags();
            
        }
    }
}
