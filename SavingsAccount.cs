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

        public SavingsAccount(string owner, decimal initialDeposit, decimal interest):base(owner + " (S) ", 0) // "("+interest+"%)"
        {
            InterestRate = interest;
        }


    }
}
