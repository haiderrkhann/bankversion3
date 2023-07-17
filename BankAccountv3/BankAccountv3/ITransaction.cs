using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountv3
{
    public interface ITransaction
    {
        void ExecuteTransaction(double amount);
        void PrintTransaction();
    }
}
