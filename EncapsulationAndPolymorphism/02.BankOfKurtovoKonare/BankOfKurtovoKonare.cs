using System;
using System.Collections.Generic;
using BankOfKurtovoKonare.Classes;
using BankOfKurtovoKonare.Classes.Accounts;

namespace BankOfKurtovoKonare
{
    public class BankOfKurtovoKonare
    {
        public static void Main()
        {

            List<Account> accountList = new List<Account>();

            try
            {
                Customer ibm = new Customer("IBM", "company");
                Customer ivo = new Customer("Ivo", "individual");

                Customer hp = new Customer("HP", "company");
                Customer jivko = new Customer("Jivko", "individual");

                Customer ktb = new Customer("KTB", "company");
                Customer boikoBorisov = new Customer("Boiko Borisov", "individual");

                DepositAccount ibmDepositAccount = new DepositAccount(ibm, 1000000m, 5m);
                DepositAccount ivoDepositAccount = new DepositAccount(ivo, 1000m, 1m);
                accountList.Add(ibmDepositAccount);
                accountList.Add(ivoDepositAccount);

                LoanAccount hpLoanAccount = new LoanAccount(hp, 500000m, 3m);
                LoanAccount jivkoLoanAccount = new LoanAccount(jivko, 500m, 2m);
                accountList.Add(hpLoanAccount);
                accountList.Add(jivkoLoanAccount);

                MortgageAccount ktbMortgageAccount = new MortgageAccount(ktb, 1m, 0.5m);
                MortgageAccount boikoBorisovMortgageAccount = new MortgageAccount(boikoBorisov, 4000000000m, 10m);
                accountList.Add(ktbMortgageAccount);
                accountList.Add(boikoBorisovMortgageAccount);

                foreach (var account in accountList)
                {
                    Console.WriteLine(account);
                }

                Console.WriteLine();

                ivoDepositAccount.DepositMoney(1000m);
                ivoDepositAccount.WithDraw(500m);
                Console.WriteLine(ivoDepositAccount);

                jivkoLoanAccount.DepositMoney(2000m);
                Console.WriteLine(jivkoLoanAccount);

                hpLoanAccount.CalculateInterest(3);
                Console.WriteLine(hpLoanAccount);

                boikoBorisovMortgageAccount.CalculateInterest(100);
                Console.WriteLine(boikoBorisovMortgageAccount);

                ktbMortgageAccount.CalculateInterest(1000);
                Console.WriteLine(ktbMortgageAccount);
            }

            catch (NullReferenceException)
            {
                Console.Error.WriteLine("The value can not be null or empty");
                Main();
            }

            catch (FormatException)
            {
                Console.Error.WriteLine("You must enter a valid number");
                Main();
            }

            catch (OverflowException)
            {
                Console.Error.WriteLine("You must enter a valid number");
                Main();
            }

            catch (ArgumentNullException ex)
            {
                Console.Error.WriteLine(ex.Message);
                Main();
            }

            catch (ArgumentException ex)
            {
                Console.Error.WriteLine(ex.Message);
                Main();
            }

            finally
            {
                Console.WriteLine();
                Console.WriteLine("Good bye. Have a nice day");
            }
        }
    }
}
