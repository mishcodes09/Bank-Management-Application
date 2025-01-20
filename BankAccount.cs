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
        public decimal Balance { get; set; }

        public BankAccount(string owner, decimal initialDeposit)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = initialDeposit;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount; // Increase balance by the deposit amount
            }
            else
            {
                throw new ArgumentException("Deposit amount must be greater than zero.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
            {
                Balance -= amount; // Reduce balance by withdrawal amount
            }
            else if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero.");
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds for this withdrawal.");
            }
        }
    }
}
