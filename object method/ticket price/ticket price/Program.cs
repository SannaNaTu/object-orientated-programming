using System;

namespace TicketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Maatalousnäyttelyn lipunhinta");
            Ticket ticket = new Ticket();
            ticket.AskInfo();
            ticket.TicketPrice();
            Console.ReadKey();

        }
    }
}
