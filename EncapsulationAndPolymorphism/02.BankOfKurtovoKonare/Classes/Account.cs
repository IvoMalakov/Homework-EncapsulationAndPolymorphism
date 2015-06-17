using System;
using BankOfKurtovoKonare.Interfaces;


namespace BankOfKurtovoKonare.Classes
{
    public abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        protected Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }

        public decimal Balance
        {
            get { return this.balance; }

            set
            {
                if (value < 0m)
                {
                    throw new ArgumentException("The balance of your account can not be nagative");
                }

                this.balance = value;
            }
        }


        public decimal InterestRate
        {
            get { return this.interestRate; }

            set
            {
                if (value < 0m)
                {
                    throw new ArgumentException("The interest rate of your account can not be nagative");
                }

                this.interestRate = value;
            }
        }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public abstract decimal CalculateInterest(int months);

        public override string ToString()
        {
            return String.Format("{0}, Account balace: {1}, \nAccount interest rate: {2}", this.Customer.ToString(),
                this.Balance, this.InterestRate);
        }
    }
}
