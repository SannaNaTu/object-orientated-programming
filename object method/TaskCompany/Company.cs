using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCompany
{
    class Company
    {
        //Fields 
        public string Title;
        public string Address;
        public string Phone;
        public double Income;
        public double Expense;

        //Constuctor =muodostin //tehtävä oletusmuodostin (parametritön) eli ei palauta mitään arvoa
        public Company()
        {
            Title = "-";
            Address = "-";
            Phone = "-";
            Income = 0;
            Expense = 0;

        }
        //Constuctor =muodostin //tehtävä muodostin, joka sisältää kaikki parametrit
        public Company(string title,string address,string phone, double income, double expense)
        {
            Title = title;
            Address = address;
            Phone = phone;
            Income = income;
            Expense = expense;

        }
        //Constuctor =muodostin //tehtävä kopiontimuodostin, jolla olio voidaan kopioida. 

        public Company(Company CopyCompany)
        {
            Title = CopyCompany.Title;
            Address = CopyCompany.Address;
            Phone = CopyCompany.Phone;
            Income= CopyCompany.Income;
            Expense = CopyCompany.Expense;
        }

        public void PrintCompanyInfo()
        {
            Console.WriteLine($"Firman tiedot:");
            Console.WriteLine($"Nimi: {Title}\nOsoite: {Address}\nPuhelinnumero: {Phone}\nTulot: {Income:F}€\nTulot: {Expense:F}€\n");
        }
        //Methods   
        public string Profit(Company company)
        {
            double profit = (company.Income - company.Expense) / Expense*100;
            if (profit < 100)
            {
                return "Yhtiöllä menee kehnosti!\n";
            }
            else if (profit > 100 && profit < 300) // Miksi ei tämä osio tulostu! 
            {
                return "Yhtiöllä menee ihan ok!\n";
            }
            else 
            {
                return "Yhtiöllä menee super hyvin!\n";
            }
        }
    }
}
