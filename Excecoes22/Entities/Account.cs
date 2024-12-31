using ExExcecoes22.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExExcecoes22.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withdrawLimit;
        }

        public void RegisterAccount()
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            String holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withdrawLimit;
            ShowDatas();
        }

        public void ShowDatas()
        {
            Console.WriteLine($"Number account: {Number} - Holder: {Holder} - Balance: {Balance} " +
                $"- With Draw limit {WithDrawLimit}");
        }

        public void Deposit()
        {
            Console.Write("Value of deposit: ");
            double value = double.Parse(Console.ReadLine());

            Balance += value;
            ShowDatas();
        }

        public void WithDraw()
        {
            Console.Write("Value of withdraw: ");
            double value = double.Parse(Console.ReadLine());

            if (value > WithDrawLimit)
            {
                throw new DomainException("With draw limit exceed!");
            }
            else if (value > Balance)
            {
                throw new DomainException("INSUFFICIENT BALANCE!");
            }
            Balance -= value;

            Console.WriteLine("Updated data");
            ShowDatas();
        }
    }
}
