using System;

namespace Assignment_2_Bank_Account
{
    class Program
    {

        static void Main(string[] args)
        {
            Account Intouch = new Account("Inn", 25);
            Console.WriteLine(Intouch.CheckBalance());
            Console.WriteLine(Intouch.AddInterest(1.05));

        }
    }
}
