using System;

namespace TicketPrice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Maatalousnäyttelyn lipunhinta");
            Console.Write("Anna nimesi: ");
            var name = Console.ReadLine();
            var customer = new Customer(name);
            customer.IsMtkMember = YesNo("On Mtk-jäsen.");



        }
    }
}
