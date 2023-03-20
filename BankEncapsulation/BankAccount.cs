using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public double Deposit(double amount)
        {
            _balance += amount;

            return _balance;
        }

        public double GetBalance()
        { 
            return _balance; 
        }


    }
}
