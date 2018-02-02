using System;

namespace BookNWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Kirjallisuus.Book book = new Kirjallisuus.Book();
            Kirjallisuus.Book.BookTheme = "xx";
            Console.WriteLine(book.GetBook(book));
            Console.WriteLine(book.CompareBook("Kirja 1"));

            Kirjallisuus.Book book2 = new Kirjallisuus.Book("Testikirja", "Tellu",32,"Kauhu");
            Console.WriteLine(book2.GetBook(book));
            book2.Name = "Uusnimi";
            Kirjallisuus.Book.BookTheme = "Seikkailu";
            Console.WriteLine(book2.CompareBook("Uusnimi"));

            Kirjallisuus.Author KirjailijaArttu = new Kirjallisuus.Author("Arttu", "2.3.1978", book2);
            Kirjallisuus.Author Kirjailija1 = new Kirjallisuus.Author("Testi", "päivä", new Kirjallisuus.Book("testi","tatti",55,"kauhu"));
            Console.WriteLine(KirjailijaArttu.AuthorInfo());
            Console.WriteLine(Kirjailija1.AuthorInfo());

            Console.ReadKey();

           
        }
    }
}
