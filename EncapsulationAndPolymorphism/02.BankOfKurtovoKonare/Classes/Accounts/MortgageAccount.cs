using System;

namespace BankOfKurtovoKonare.Classes.Accounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate) :
            base(customer, balance, interestRate)
        {

        }

        public override decimal CalculateInterest(int months)
        {

            this.InterestRate = this.Balance*(1 + this.InterestRate * months);

            if (this.Customer.CustomerType == "company" && months <= 12)
            {
                return this.InterestRate / 2;
            }

            else if (this.Customer.CustomerType == "individual" && months <= 6)
            {
                return 0;
            }

            else
            {
                return this.InterestRate;
            }
        }
    }
}