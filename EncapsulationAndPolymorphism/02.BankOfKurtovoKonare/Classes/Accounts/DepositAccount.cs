using System;

namespace BankOfKurtovoKonare.Classes.Accounts
{
    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) :
            base(customer, balance, interestRate)
        {
            
        }

        public override decimal CalculateInterest(int months)
        {
            if (0 < this.Balance && this.Balance < 1000)
            {
                return 0;
            }

            else
            {
                this.InterestRate = this.Balance * (1 + this.InterestRate * months);
                return this.InterestRate;
            }
        }

        public void WithDraw(decimal money)
        {
            this.Balance -= money;
        }
    }
}
