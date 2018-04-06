using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask
{
    class Customer : ICustomer
    {
        //fields
        public string Name;
        public double Groceries;

        //Constructor
        public Customer(string name, double groceries)
        {
            Name = name;
            Groceries = groceries;
        }
        //Override ToString
        public override string ToString()
        {
            return ($"\n{Name}\n{Groceries}€\n");
        }
        //ICustomer 
        public void GetCustomer()
        {
            string NewCustomer = Name;
            if (NewCustomer == Name)
            {
                Console.WriteLine($"{Name}");
            }
            else
            {
                Console.WriteLine($"{null}");
            }
        }
        //Bonus-laskuri
        public void CountBonus()
        {
            double Total;
            if (Groceries <= 1000)
            {
                Total = Groceries * 0.02;
                Console.WriteLine($"Bonusprosentti on 2%. Bonus: {Total}€");
            }
            else if (Groceries > 1000 && Groceries < 200)
            {
                Total = Groceries * 0.03;
                Console.WriteLine($"Bonusprosentti on 3%. Bonus: {Total}€");
            }
            else
            {
                Total = Groceries * 0.05;
                Console.WriteLine($"Bonusprosentti on 5%. Bonus: {Total}€");
            }
        }
    }
}
