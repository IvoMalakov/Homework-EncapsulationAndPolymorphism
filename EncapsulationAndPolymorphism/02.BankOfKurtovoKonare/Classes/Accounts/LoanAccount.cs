using System;


namespace BankOfKurtovoKonare.Classes.Accounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) :
            base(customer, balance, interestRate)
        {
            
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer.CustomerType == "individual" && months <= 3)
            {
                return 0;
            }

            else if (this.Customer.CustomerType == "company" && months <= 2)
            {
                return 0;
            }

            else
            {
                this.InterestRate = this.Balance * (1 + this.InterestRate * months);
                return this.InterestRate;
            }
        }
    }
}
