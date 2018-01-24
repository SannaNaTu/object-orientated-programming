using System;
using System.Collections.Generic;
using System.Text;

namespace TicketPrice
{
    class Ticket
    {
        public string Name;
        public int Age;
        //public string Conscript; // varusmies
        //public string Mtk; //MTK-jäsen
        //public string Student;


        //public Ticket(string name, int age) //, string conscript, string mtk, string student
        //{
        //    Name = name;
        //    Age = age;
        //    //Conscript = conscript;
        //    //Mtk = mtk;
        //    //Student = student;

        //}
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
                    Console.ReadLine();
                }
                else if (Age >= 65)
                {
                    discount = 100;
                    Console.WriteLine($"Hei, {Name} lippusi hinta on: {price - (price * discount / 100)}€");
                    Console.ReadLine();
                }
                else if (Age > 15 && Age < 65)
                {

                }

            }
        
    }
}
