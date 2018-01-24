using System;
using System.Collections.Generic;
using System.Text;

namespace TicketPrice
{
    class Ticket
    {
        public string Name;
        public int Age;

            public void AskInfo()
            {
                Console.Write("Anna nimesi: "); // Kysytään nimi
                Name = Console.ReadLine();
                Console.Write("Anna ikäsi: "); // Kysytään ikä
                Age = int.Parse(Console.ReadLine());
            }

        public void TicketPrice()
        {
            float discount = 0;
            float price = 16;
            if (Age < 7)
            {
                discount = 100;
                Console.WriteLine($"Hei, {Name} lippusi hinta on: {price - (price * discount / 100)}€");
                Console.ReadLine();
            }
            else if (Age >= 7 && Age <= 15)
            {
                discount = 50;
                Console.WriteLine($"Hei, {Name} lippusi hinta on: {price - (price * discount / 100)}€");

            }
            else if (Age >= 65)
            {
                discount = 100;
                Console.WriteLine($"Hei, {Name} lippusi hinta on: {price - (price * discount / 100)}€");

            }
            else if (Age > 15 && Age < 65)
            {
                Console.Write("Oletko varusmies? Y/N: ");
                string conscriptResponse = Console.ReadLine().ToUpper();
                if (conscriptResponse == "Y")
                {
                    discount = 50;

                }
                else
                {
                    Console.Write("Oletko MTK:n jäsen? Y/N:");
                    string mtkresponse = Console.ReadLine().ToUpper();
                    if (mtkresponse == "Y")
                    {
                        discount = 15;

                    }
                    Console.Write("Oletko opiskelija? Y/N:");
                    string studentresponse = Console.ReadLine().ToUpper();
                    if ( studentresponse == "Y")
                    {
                        discount = discount + 45;

                    }
                }
                Console.WriteLine($"Hei, {Name} lippusi hinta on: {price - (price * discount / 100)}€");

            }

            }

        }
           
                

            
        
    
}
