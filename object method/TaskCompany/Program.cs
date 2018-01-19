using System;

namespace TaskCompany
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Company company = new Company("Pikku Firma", "Pikkukatu","050123123",40000,20000 );
            Company company1 = new Company(company);
            Company company2 = new Company("Iso Firma", "Isokatu", "-", 1000000, 1000000);
            Company company3 = new Company(company2);
            company3.Income = 640000;
            company3.Expense = 320000;

            company.PrintCompanyInfo();
            Console.WriteLine(company.Profit(company));
            company1.PrintCompanyInfo();
            Console.WriteLine(company1.Profit(company1));
            company2.PrintCompanyInfo();
            Console.WriteLine(company2.Profit(company2));
            company3.PrintCompanyInfo();
            Console.WriteLine(company3.Profit(company3));

            Console.ReadKey();


        }
    }
}
