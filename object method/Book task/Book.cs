using System;
using System.Collections.Generic;
using System.Text;

namespace BookTask
{
    // Luokka = class, nimi kirjoitetaan aina Isolla,määrittelee olion tietorakenteen (mm. metodit, attribuutit, kentät)
    class Book
    {
        //Fields  (kirjassa attribuutit,olioiden ominaisuuksia, jäsenmuuttujat)
        // public, näkyy kaikille, Kirjota Isolla/ private, näkyy vain luokassa, Kirjota _eteen, muut :protected, internal, protected internal
        public string Title;
        public string Author;
        public int Id;
        public double Price;

        //Constuctor =muodostin, asetetaan jäsenmuuttujille arvot,ei palauta mitään arvoa eikä sille voida määritellä mitään paluuarvon tyyppiä
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
        //Methods ( olioiden toiminnat, tehtävät, käyttötarkoitukset, jäsenfunktiot, kirjoitetaan Isolla)
        public void PrintBookInfo()
        {
            Console.WriteLine($"Nimi: {Title}\nKirjoittaja: {Author}\nId-numero: {Id}\nHinta: {Price:F}€"); //miksi ei ohjelma tulosta nollia? 
        }
        //this. = operaattori viittaa käsittelyssä olevaan olioon eli siihen, jonka metodeja käytetään

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

