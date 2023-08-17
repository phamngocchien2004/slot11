using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slot11.amslot11
{


    public class BankAccount
    {
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value != balance)
                {
                    balance = value;
                    OnBalanceChanged();
                }
            }
        }
        public event EventHandler SoDuThayDoi;

        protected virtual void OnBalanceChanged()
        {
            SoDuThayDoi?.Invoke(this, EventArgs.Empty);
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive.", nameof(amount));

            }
            Balance += amount;
        }




        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive.", nameof(amount));
            }

            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient balance.");
            }

            Balance -= amount;
        }
    }

}
