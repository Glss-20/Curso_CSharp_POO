using ExExcecoes22.Entities.Exceptions;
using ExExcecoes22.Entities;
using System.Security.Principal;

namespace ExExcecoes22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Account account = new Account();
                account.RegisterAccount();
                account.Deposit();
                account.WithDraw();
                Console.ReadLine();
            }
            catch (DomainException ex)
            {
                Console.WriteLine($"Error in operation: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
