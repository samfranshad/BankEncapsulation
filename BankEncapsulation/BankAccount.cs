using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class BankAccount
    {
        private double _checkingBalance = 37.56;
        private double _savingsBalance = 8456.23;

        public double CheckingDeposit (double amount)
        {
            return _checkingBalance += amount;
        }

        public double SavingsDeposit (double amount)
        {
            return _savingsBalance += amount;
        }

        public double GetCheckingBalance()
        {
            return _checkingBalance;
        }

        public double GetSavingsBalance()
        {
            return _savingsBalance;
        }

        public double TransferCheckingToSavings (double transferAmount)
        {
            _checkingBalance -= transferAmount;
            _savingsBalance += transferAmount;
            return _savingsBalance;
        }

        public double TransferSavingsToChecking (double transferAmount)
        {
            _savingsBalance -= transferAmount;
            _checkingBalance += transferAmount;
            return _checkingBalance;
        }
    }
}
