using System;
using System.Collections.Generic;
using System.Text;

namespace BookNWriter
{
    class Book //Luokka
    {
        //Fields, atribuutit, ( privaatit siksi _-viiva)
        string _name;
        readonly string _author;
        double _price;

        static string _bookTheme;

        public string Name { get => _name; set => _name = value; }
        public static string BookTheme { get => _bookTheme; set => _bookTheme = value; }
        public double Price
        {
            get => _price;

            set
            {
                _price = value;
                if (value >= 30)
                {
                    _price *= 0.9; // 10% discount 
                }
            }
        }

        //Muodostin
        public Book()
        {
            Name = "Kirja 1";
            _author= "Kirjamies Kimmo";
            Price = 10;
            BookTheme = "Fantasia";
        }
        public Book(string name, string author, double price, string bookTheme)
        {
            Name = name;
            _author = author;
            Price = price;
            BookTheme = bookTheme;
        }
        //Metodit
        public string GetBook(Book book)

        {

            return $"------------------\n" +
                   $"Kirja: {Name}\n" +            
                   $"Hinta: {Price}\n" +
                   $"Teema: {BookTheme}\n";

        }
        public string GetBook()
        {
            return $"------------------\n" +
                   $"Kirja: {Name}\n" +
                   $"Hinta: {Price}\n" +
                   $"Teema: {BookTheme}\n";
        }
        public string CompareBook(string theme)
        {
            if (theme == Name)
                return $"{theme} Löytyy valikoimasta!";
            else 
                    return $"{theme} Ei löydy valikoimasta!";

        }
        

    }

    class Author // Uusi luokka 
    {
        string _name;
        string _bday;
        Book bookXXX;


        public Author(string name, string bday, Book book)
        {
            _name = name;
            _bday = bday;
            bookXXX = book;

        }
        public Author()
        {
            _name = "Kirja Maija";
            _bday = "01.05.1500";
            bookXXX = new Book();

        }
        public string AuthorInfo()
        {
            return $"Nimi: {_name}" +
                $" ja syntymäpäivä: {_bday}\n" +
                $"Kirjopittanut kirjan:\n {bookXXX.GetBook()}";
        }


    }

}
