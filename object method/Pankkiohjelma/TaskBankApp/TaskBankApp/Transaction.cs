using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TaskBankApp
{
    class Transaction
    {
        private double _sum;
        private DateTime _timestamp;

        public Transaction(double sum, DateTime timestamp)
        {
            _sum = sum;
            Timestamp = timestamp;
        }

        public double Sum
        {
            get => _sum;
            set => _sum = value;
        }
        public DateTime Timestamp { get => _timestamp; set => _timestamp = value; }
    }
}
