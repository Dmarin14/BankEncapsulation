using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulationExcersize
{
    public class BankAccount
    {
        private double _balance;


        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public double Deposit(double b)
        {
            return Balance += b;
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}
