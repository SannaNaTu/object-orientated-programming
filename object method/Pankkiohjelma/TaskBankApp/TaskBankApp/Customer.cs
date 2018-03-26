using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TaskBankApp
{
    class Customer
    {
        private string _accountNumber;
        private string _firstName;
        private string _lastName;

        public Customer(string accountNumber, string firstName, string lastName)
        {
            _accountNumber = accountNumber;
            FirstName = firstName;
            LastName = lastName;
        }

        public string AccountNumber
        {
            get => _accountNumber;
            set => _accountNumber = value;
        }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {_accountNumber}";
        }
    }
}
