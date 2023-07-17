using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountv3
{
    public class SavingsAccount : BankAccount, ITransaction
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int accountNumber, string accountHolderName, double balance, double interestRate)
            : base(accountNumber, accountHolderName, balance)
        {
            InterestRate = interestRate * 100;
        }

        public override void Deposit(double amount)
        {
            double interest = amount * InterestRate;
            Balance += amount + interest;
            Console.WriteLine($"Deposited {amount} with interest {InterestRate}%. New balance: {Balance}");
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Savings Account Information");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine($"Interest Rate: {InterestRate}%");
        }
    }
}
