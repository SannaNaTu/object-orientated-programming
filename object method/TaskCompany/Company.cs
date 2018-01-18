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
        public double Outcome;
        public double Expense;

        //Constuctor =muodostin //tehtävä oletusmuodostin (parametritön) eli ei palauta mitään arvoa
        public Company()
        {
            Title = "Pikku Firma";
            Address = "Pikkufirmantie";
            Phone = "050123456";
            Outcome = 10000;
            Expense = 5000;

        }
        //Constuctor =muodostin //tehtävä muodostin, joka sisältää kaikki parametrit
        public Company(string Title,string Address,string Phone, double Outcome, double Expense)
        {

        }
        //Constuctor =muodostin //tehtävä kopiontimuodostin, jolla olio voidaan kopioida. 

            public Company(Company CopyCompany)
        {
            Title = CopyCompany.Title;
            Address = CopyCompany.Address;
            Phone = CopyCompany.Phone;
            Outcome = CopyCompany.Outcome;
            Expense = CopyCompany.Expense;
        }

        public void PrintCompanyInfo()
        {
            Console.WriteLine($"Firman tiedot:");
            Console.WriteLine($"Nimi: {Title}\nOsoite: {Address}\nPuhelinnumero: {Phone}\nTulot: {Outcome:F}€\nTulot: {Expense:F}€");
        }
        //Methods   
        //Määritä luokalle myös metodi, joka tulojen ja menojen perusteella laskee firman voiton. 
        //Metodin pitää laskea voitto%=[(tulot-menot)/menot x 100] ja sen perusteella tulostaa tulostaa näytölle viesti, 
        //joka kertoo, kuinka hyvin firmalla menee.
        public void CompanyProfit ()
        {
            if ( )

        }
    }
    //1kehnosti, jos voitto on alle 100% suurempi kuin menot
    //2tyydyttävästi, jos voitto on vähintään 200% suurempi kuin menot
    //3hyvin, jos voitto on vähintään 300% suurempi kuin menot
    //Luo testausohjelmassa oliota Firma-luokasta ja kopioi yksi olio kopiointimuodostimella.
    //Luotuasi olioita, kutsu niiden metodi, joka kertoo firman tilanteesta.

}
