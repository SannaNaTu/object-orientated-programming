using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TaskBankApp

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TaskBankApp");
            Bank bank = new Bank("Sanna's BANK");

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(bank.CreateAccount(), "Sanna", "Natunen"));
            customers.Add(new Customer(bank.CreateAccount(), "Vauva", "Natunen"));
            customers.Add(new Customer(bank.CreateAccount(), "Jarkko", "Natunen"));

            bank.AddTransactionForCustomer(customers[0].AccountNumber, new Transaction(1234, new DateTime(2018, 03, 23)));
            bank.AddTransactionForCustomer(customers[1].AccountNumber, new Transaction(1234, new DateTime(2018, 03, 23)));
            bank.AddTransactionForCustomer(customers[2].AccountNumber, new Transaction(1234, new DateTime(2018, 03, 23)));

           
            

            var endTime = DateTime.Today;
            var time = new TimeSpan(24 * 30 * 6, 0, 0);
            var startTime = endTime.Date - time;
            Random rnd = new Random();

            Console.WriteLine($"Tilitapahtumat viimeisen kuuden kuukauden ajalta: {startTime.ToShortDateString()}" +
                $"-{endTime.ToShortDateString()} \n " +
                $"- - - - - - - - - - - - - - - - - - - - - - -");

            //PrintBalance(bank, customers[0]);
            //PrintTransactions(bank.GetTransactionsForCustomerForTimeSpan(customers[0].AccountNumber, startTime, endTime), customers[0]);
            //PrintBalance(bank, customers[1]);
            //PrintTransactions(bank.GetTransactionsForCustomerForTimeSpan(customers[1].AccountNumber, startTime, endTime), customers[1]);
            //PrintBalance(bank, customers[2]);
            //PrintTransactions(bank.GetTransactionsForCustomerForTimeSpan(customers[2].AccountNumber, startTime, endTime), customers[2]);

            for (int i = 0; i < 50; i++) 
            {
                bank.AddTransactionForCustomer(customers[rnd.Next(0, 3)].AccountNumber, new Transaction(rnd.Next(-10000, 50000), new DateTime(2018, rnd.Next(1, 12), rnd.Next(1, 28))));
            }
            for (int i = 0; i < customers.Count; i++)
            {
                PrintBalance(bank, customers[i]);
                PrintTransactions(bank.GetTransactionsForCustomerForTimeSpan(customers[i].AccountNumber, startTime, endTime), customers[i]);
            }






            Console.WriteLine("<Enter> lopettaa!");
            Console.ReadLine();


        }

        public static void PrintBalance(Bank bank, Customer customer)
        {
            var balance = bank.GetBalanceForCustomer(customer.AccountNumber);
            Console.WriteLine("{0} - balance: {1}{2:0.00}",
                customer.ToString(), balance >= 0 ? "+" : "", balance);
        }
        public static void PrintTransactions(List<Transaction> transactions, Customer customer)
        {
            Console.WriteLine($"Tilitapahtumat {customer.FirstName} {customer.LastName}:");



        for (int i = 0; i < transactions.Count(); i++)
            {
                Console.WriteLine("{0}\t{1}{2:0.00}",
                transactions[i].Timestamp.ToShortDateString(),
                transactions[i].Sum >= 0 ? "+" : "",
                transactions[i].Sum);

            }
            Console.WriteLine("\n");
            // tai if (transactions[i].Sum >=0)
            // Console.writeline($"{transactions[i].TimeStamp.ToShortDateString()}\t + $"+{transactions[i].Sum:F}"); else Console.WriteLine($"{transactions[i].TimeStamp.ToShortDateString()}\t + $"+{transactions[i].Sum:F}");
        }

    }
}
