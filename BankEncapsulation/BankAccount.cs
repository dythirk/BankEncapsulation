using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount() { }

        private double _balance = 0;

        public void Deposit(double moneyToAdd)
        {
            _balance += moneyToAdd;
        }

        public void Withdraw(double moneyToTake)
        {
            _balance -= moneyToTake;
        }

        public double GetBalance() 
        { 
            return _balance; 
        }
    }
}
