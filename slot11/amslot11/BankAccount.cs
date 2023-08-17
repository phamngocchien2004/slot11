using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slot11.amslot11
{
    public delegate void UpdateBalance(decimal newBalance);

    public class BankAccount
    {
        private decimal balance;
        private event UpdateBalance BalanceChanged;
        public decimal Balance
        {
            get => balance;
            set => balance = value;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                BalanceChanged(amount);
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                BalanceChanged(-amount);
            }
        }

    }
}
