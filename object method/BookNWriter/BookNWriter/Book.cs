using System;
using System.Collections.Generic;
using System.Text;

namespace BookNWriter
{
    class Book //Luokka
    {
        //Fields, atribuutit, ( privaatit siksi _-viiva)
        string _name;
        string _author;
        double _price;

        static string _bookTheme;

        //Muodostin
        public Book()
        {
            _name = "Kirja 1";
            _author= "Kirjamies Kimmo";
            _price = 10;
            _bookTheme = "Fantasia";
        }
        public Book(string name, string author, double price, string bookTheme)
        {
            _name = name;
            _author = author;
            _price = price;
            _bookTheme = bookTheme;
        }
        //Metodit
        public void GetBook()
        {
         

        }
        public void ChangeBookTheme()
        {

        }
        public void GetInfo()
        {
            Console.WriteLine($"Nimi: {_name}\nKirjoittaja: {_author}\nHinta: {_price:F}€\nTeema:{_bookTheme}");
        }

    }
}
