using System;


namespace BankOfKurtovoKonare.Classes
{
    public class Customer
    {
        private string customerName;
        private string customerType;

        public Customer(string customerName, string custmerType)
        {
            this.CustomerName = customerName;
            this.CustomerType = custmerType;
        }

        public string CustomerName 
        {
            get { return this.customerName; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Your customer name can not be null or empty");
                }

                this.customerName = value;
            }
        }

        public string CustomerType
        {
            get { return this.customerType; }

            set
            {
                if (!(value.Equals("individual".Trim().ToLower()) || value.Equals("company".Trim().ToLower())))
                {
                   throw new ArgumentOutOfRangeException("value" , "Your customer type can be only: individual or company");
                }

                this.customerType = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Customer name: {0}, Customer Type: {1}", this.CustomerName, this.CustomerType);
        }
    }
}
