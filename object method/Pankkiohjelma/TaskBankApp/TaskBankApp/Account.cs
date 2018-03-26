using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TaskBankApp
{
    class Account

    {
        private string _accountNumber;
        private double _balance;
        private List<Transaction> _transactions;

        public Account(string accountNumber)
        {
            _accountNumber = accountNumber;
            _transactions = new List<Transaction>();
        }

        public Account(string accountNumber, double balance, List<Transaction> transactions)
        {
            _accountNumber = accountNumber;
            _balance = balance;
            _transactions = transactions;
        }

        public string AccountNumber
        {
            get => _accountNumber;
            set => _accountNumber = value;
        }
        public double Balance
        {
            get => _balance;
            set => _balance = value;
        }

        public bool AddTransaction(Transaction transaction)
        {
            bool res = false;

            _transactions.Add(transaction);
            double balanceBeforeTransaction = Balance;
            if (_transactions.Last().Equals(transaction))
            {
                Balance += transaction.Sum;
            }
            if (Balance - transaction.Sum == balanceBeforeTransaction)
            {
                res = true;
            }
            return res;
        }
        public List<Transaction> GetTransactionsForTimeSpan(DateTime startTime, DateTime endTime)
        {
            List<Transaction> res = (from transaction in _transactions
                                     where transaction.Timestamp >= startTime && transaction.Timestamp <= endTime
                                     orderby transaction.Timestamp
                                     select transaction).ToList();
            return res;

        }
    }
    
}
