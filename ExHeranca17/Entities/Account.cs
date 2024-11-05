using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca17.Entities
{   
    class Account
    {
        public int Number { get; private set; }// "private", só pode ser modificado dentro da classe.
        public string Holder { get; private set; }// "private", só pode ser modificado dentro da classe.
        public double Balance { get; protected set; }// O "protected" indica que esse atributo pode ser modificado
                                                     // dentro da classe e de uma subclasse derivada.

        public Account() 
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        // O "virtual" indica que o método pode ser sobreposto ou sobrescrito nas subclasses, igual na classe "SavingsAccount".
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }


    }
}
