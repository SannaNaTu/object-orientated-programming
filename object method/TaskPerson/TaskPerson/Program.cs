using System;

namespace TaskPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personSanna = new Person();
            personSanna.Name = "Sanna N";
            personSanna.GrowOld();
            personSanna.PrintPersonInfo();

            Person newPerson = new Person(" Joe Doe", 17);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();
            Console.ReadKey();

        }
    }
}
