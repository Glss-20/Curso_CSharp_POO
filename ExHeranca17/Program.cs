using ExHeranca17.Entities;

namespace ExHeranca17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(100, "Ale", 0.0);

            BussinesAccount bacc = new BussinesAccount(101, "Bia", 0.0, 500.00);

            // UPCASTING
            Account account1 = bacc;
            Account account2 = new BussinesAccount(102, "Jon", 0.0, 200.00);
            Account account3 = new SavingsAccount(103, "Armando", 0.0, 300.00);

            // DOWNCASTING - operação insegura
            BussinesAccount bacc1 = (BussinesAccount)account2;
            bacc1.Loan(100.00); // "bacc" é do tipo que possui o método "Loan", tipo "BussinesAccount".
            //account2.Loan(100.00); // "account2" não é do tipo que possui o método "Loan", tipo "Account".

            Account acc1 = new Account(200, "Alesandro", 0.0);
            Account acc2 = new SavingsAccount(200, "Alex", 0.0, 0.1);
            acc1.Withdraw(20);
            acc2.Withdraw(20);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
