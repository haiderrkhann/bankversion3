using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountv3
{
    public class CheckingAccount : BankAccount, ITransaction
    {
        public CheckingAccount(int accountNumber, string accountHolderName, double balance)
            : base(accountNumber, accountHolderName, balance)
        {
        }

        public override void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn {amount}. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance to withdraw.");
            }
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Checking Account Information");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
