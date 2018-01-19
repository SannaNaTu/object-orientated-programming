using System;

namespace BookTask
{
    class Program

    {
        //Vähän sekava kun mukana muistiinpanoja!
        static void Main(string[] args)
        {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

            Book book = new Book(); // new:llä luodaan aina uusi olio, object,instanssi,Muodostin funktiota kutsutaan instanssin muodostuksen yhteydessä new-lauseella
            book.PrintBookInfo(); // tulostaa kirjan tiedot
            Book newBook = new Book("C#- Ohjelmointi", "Ghodrat Moghadampour", 97895, 29.90);
            newBook.PrintBookInfo(); // tulostaa uuden kirjan tiedot
            Console.WriteLine(newBook.CompareBook(book)); //vertaa hintoja
            Console.ReadKey();

        }
    }
}
