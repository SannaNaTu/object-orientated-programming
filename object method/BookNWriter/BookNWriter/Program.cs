using System;

namespace BookNWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Literature.Book book = new Literature.Book(); // Uusi kirja 
            Literature.Book.BookTheme = "Scifi";  // Testataan uuden teeman antoa
            Console.WriteLine(book.GetBook(book));
            Console.WriteLine(book.CompareBook("The Kirja")); // Verrataan nimiä

            Literature.Book book2 = new Literature.Book("Tylsät seikkailut", "Tellu tampio",32,"Kauhu"); //Luodaan uusi kirja uusilla tiedoilla
            Console.WriteLine(book2.GetBook(book));
            book2.Name = "Suuret Seikkailut"; // Annetaan uudelle kirjalle uusi nimi
            Literature.Book.BookTheme = "Seikkailu"; // Vaihdetaan teema
            Console.WriteLine(book2.CompareBook("Suuret Sikailut")); //Verrataan nimiä

            Author Author1 = new Author("Arttu Jalomies", "2.3.1978", book2);
            Author Author2 = new Author("Anna Palonais", "2.2.2020", new Literature.Book("Taivas rajana","Tatti Tavallinen",55,"kauhu")); // luodaan myös uusi kirja
            Console.WriteLine(Author1.AuthorInfo());
            Console.WriteLine(Author2.AuthorInfo());

            Console.ReadKey();

        }
    }
}
