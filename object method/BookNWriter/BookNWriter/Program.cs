using System;

namespace BookNWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Book book = new Book();
            Book.BookTheme = "xx";
            Console.WriteLine(book.GetBook(book));
            Console.WriteLine(book.CompareBook("Kirja 1"));

            Book book2 = new Book("Testikirja", "Tellu",32,"Kauhu");
            Console.WriteLine(book2.GetBook(book));
            book2.Name = "Uusnimi";
            Book.BookTheme = "Seikkailu";
            Console.WriteLine(book2.CompareBook("Uusnimi"));

            Author KirjailijaArttu = new Author("Arttu", "2.3.1978", book2);
            Console.WriteLine(KirjailijaArttu.AuthorInfo());
            Console.ReadKey();

           
        }
    }
}
