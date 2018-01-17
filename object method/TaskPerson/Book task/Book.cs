using System;
using System.Collections.Generic;
using System.Text;

namespace BookTask
{
    // Luokka = class, nimi kirjoitetaan aina Isolla
    class Book
    {
        //Fields  (kirjassa attribuutit,olioiden ominaisuuksia, jäsenmuuttujat)
        // public, näkyy kaikille / private, näkyy vain luokassa
        // jäsenmuuttujat  ja jäsenfunktiot 
        public string Title;
        public string Author;
        public int Id;
        public double Price;

        //Constuctor =muodostin, muuttujille arvot
        public Book()
        {
            Title = "Thinking in Java";
            Author = "Bruce Eckel's";
            Id = 95499;
            Price = 46.70;
        }
        public Book(string title, string author, int id, double price)
        {
            Title = title;
            Author = author;
            Id = id;
            Price = price;

        }
        //Methods ( olioiden toiminnat, tehtävät, käyttötarkoitukset)
        public void PrintBookInfo()
        {
            Console.WriteLine($"Nimi: {Title}\nKirjoittaja: {Author}\nId-numero: {Id}\nHinta: {Price}€");
        }
        //    //this. = operaattori viittaa käsittelyssä olevaan olioon eli siihen, jonka metodeja käytetään
        //}

            // Tämä Jounin mallista
        public string CompareBook(Book book)
        {
            if (this.Price > book.Price)
                return $"{this.Title} on kalliimpi kuin {book.Title} kirja";
            else if (this.Price < book.Price)
                return $"{book.Title} on kalliimpi kuin {this.Title} kirja";
            else
                return $"Hinnat ovat yhtä suuret";

}
    }
}
