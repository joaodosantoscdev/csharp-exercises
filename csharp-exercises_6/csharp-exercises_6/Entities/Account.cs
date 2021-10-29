using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercises_6.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("The withdraw limit cannot be bigger than your balance");
            }
            if (Balance < 0)
            {
                throw new DomainException("Your balance is zero");
            }
            if (amount > WithdrawLimit)
            {
                throw new DomainException("You can exceed your withdraw limit");
            }

            Balance -= amount;
        }
    }
}
