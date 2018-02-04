using System;
using System.Collections.Generic;
using System.Text;

namespace BookNWriter
{
    namespace Literature
    {


        class Book //Luokka
        {
            //Fields, atribuutit, ( privaatit siksi _-viiva)
            string _name;
            readonly string _author;
            double _price;

            static string _bookTheme;
            //Encapsulated properties
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
                Name = "The Kirja";
                _author = "Kirjamies Kimmo";
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

                return 
                       $"Kirja: {Name}\n" +
                       $"Hinta: {Price}€\n" +
                       $"Teema: {BookTheme}\n";

            }
            public string GetBook()
            {
                return 
                       $"Kirja: {Name}\n" +
                       $"Hinta: {Price}€\n" +
                       $"Teema: {BookTheme}\n";
            }
            public string CompareBook(string theme)
            {
                if (theme == Name)
                    return $"{theme}: Löytyy valikoimasta!\n" +
                        $"===================\n";

                else
                    return $"{theme}: Ei löydy valikoimasta!\n" +
                        $"===================\n";
                      

            }


        }



    }
        class Author // Uusi luokka , nimiavaruuden Literature ulkopuolella
    {
            string _name;
            string _birthday;
            Literature.Book bookOne;


            public Author(string name, string birthday, Literature.Book book)
            {
                _name = name;
                _birthday = birthday;
                bookOne = book;

            }
            public Author()
            {
                _name = "Kirja Maija";
                _birthday = "01.05.1500";
                bookOne = new Literature.Book();

            }
            public string AuthorInfo()
            {
            return
                $"Kirjailijan nimi: {_name}\n" +
                $"Syntymäpäivä: {_birthday}\n" +
                $"- - - - - - - - - -\n" +
                $"Kirjoittanut kirjan:\n{bookOne.GetBook()}"+
                $"===================\n";
            }


        }
     
}
