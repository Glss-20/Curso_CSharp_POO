using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca17.Entities
{
    sealed class SavingsAccount : Account
    // O "sealed" indica que a classe é selada, ou seja, não podem ser criadas subclasses herdando o "SavingAccount".
    {
        public double InterestRate { get; set; }

        public SavingsAccount() 
        { 
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        // O "override" indica que o método está sendo sobreposto ou sobrescrito de uma SuperClass, que nesse caso é a "Account".
        // Aqui a gente reimplementa o método para dar um comportamento diferente a ele.
        {
            Balance -= amount;
        }
    }
}
