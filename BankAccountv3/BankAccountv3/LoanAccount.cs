using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountv3
{
    public class LoanAccount : BankAccount, ITransaction
    {
        public double LoanDuration { get; set; }
        public double InterestRate { get; set; }
        public double LoanAmount { get; set; }
        double interestAmount = 0;

        public LoanAccount(int accountNumber, string accountHolderName, double balance, double interestRate, double loanDuration)
            : base(accountNumber, accountHolderName, balance)
        {
            InterestRate = interestRate * 100;
            LoanDuration = loanDuration;
        }

        public override void Deposit(double amount)
        {
            LoanAmount -= amount;
            Console.WriteLine($"The amount now deposited after loan is {amount}");
            Console.WriteLine($"The total loan amount after deposit is: {LoanAmount}");
        }
        public override void TakeLoan(double amount)
        {
            Console.WriteLine($"The basic loan amount is {amount}");
        }

        public override void Withdraw(double amount)
        {
            LoanAmount += amount;
            Console.WriteLine($"The amount now withdrawn after loan is {amount}");
            Console.WriteLine($"The total loan amount after withdraw is: {LoanAmount}");
        }
        public override void InterestCalculation(double amount)
        {
            interestAmount = LoanDuration * (InterestRate / 100) * amount;
            Console.WriteLine($"The value of interest is: {interestAmount}");
            Console.WriteLine("Loan amount:" + (interestAmount + amount));
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Loan Account Information");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance}");
            Console.WriteLine($"Interest Rate: {InterestRate}%");


        }
    }
}
