using System;

namespace BookNWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Book book = new Book();
            book.GetInfo();
            
            book.GetBook();
            Console.ReadKey();
        }
    }
}
