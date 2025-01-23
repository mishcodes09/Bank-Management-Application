using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApplication
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string owner, decimal initialDeposit)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = initialDeposit;
        }


        public string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You cannot deposit $" + amount;
            if (amount > 20000)
                return "Deposit limit reached";

            Balance += amount;
            return "Deposit completed successfully";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
                return "You cannot withdraw $" + amount;
            if (amount > Balance)
                return "Sorry! You dont have enough money.";

            Balance -= amount;
            return "Withdraw completed successfully";
        }
    }
}
