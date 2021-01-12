using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2_Bank_Account
{
    class Account
    {
        private string name;
        private double balance;

        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public double CheckBalance()
        {
            return balance;
        }

        public double WithdrawMoney(double MoneyOut)
        {
            if(MoneyOut > balance)
            {
                Console.WriteLine("You do not have enough money");
            }
            else if(MoneyOut > 0) //prevents double negatives, allowing a negative input to not
            {
                Console.WriteLine("Withdraw successful!");
                balance = balance - MoneyOut;
            }
            else
            {
                Console.WriteLine("Dont try to scam with negative nums >:(");
            }
            return balance;

        }
        public double DepositMoney(double MoneyIn)
        {
            if (MoneyIn > 0)
            {
                Console.WriteLine("Aight money is in");
                balance = balance + MoneyIn;
             }
           else
            {
                Console.WriteLine("What the bean, thats not ok");
            }
            return balance;
        }

        public double AddInterest(double InterestRate)
        {
            string date = DateTime.Now.ToShortDateString();
            Console.WriteLine(date);
            if (date == "1/12/2021")
            {
                balance = balance * InterestRate;
            }
            return balance;
          
        }
    }
}
