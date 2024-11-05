using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExHeranca17.Entities
{
    class BussinesAccount : Account 
    // Com isso a classe "BussinesAccount" tem todos os atributos e métodos da classe "Account".
    {
        public double LoanLimit {  get; set; }// Esse atributo é propriedade somente da classe "BussinesAccount";
        // Ou seja, essa classe tem os 3 atributos da classe "Account" mais esse que foi declarado.
        public BussinesAccount() 
        { 
        }

        public BussinesAccount(int number, string holder, double balance, double loanLimit) 
        : base(number, holder, balance)
        // Com o "base" estamos aproveitando o construtor da classe "Account", assim passamos
        // apenas o atributo da classe "BussinesAccount", o "LoanLimit"  
        { 
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }

    }
}
