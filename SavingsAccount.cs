using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApplication
{
    public class SavingsAccount: BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner, decimal initialDeposit, decimal interest):base(owner + $" ({interest}%)", 0) // "("+interest+"%)"
        {
            InterestRate = interest;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You cannot deposit $" + amount;
            if (amount > 20000)
                return "Deposit limit reached";

            decimal interestAmount = (InterestRate/100) * amount;
            Balance += amount + interestAmount;
            return "Deposit completed successfully";
        }

        public override string Withdraw(decimal amount)
        {
            if (amount <= 0)
                return "You cannot withdraw $" + amount;
            if (amount > Balance)
                return "Sorry! You don't have enough money.";

            // Simply deduct the amount from the balance
            Balance -= amount;

            return "Withdraw completed successfully.";
        }
    }
}
