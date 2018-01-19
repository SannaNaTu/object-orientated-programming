using System;

namespace TaskEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Luodaan työntekijä oliot 3kpl
            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Sanna",12345,"Esimies",3000);
            employees[1] = new Employee("Anna", 12346, "Esimies", 3800);
            employees[2] = new Employee("Ana", 12347, "Esimies", 2600);
            //Antaa työntekijöiden tiedot
            for(int i = 0; i<employees.Length;i++)
                employees[i].PrintEmployeeInfo();
            //Vertaa työntekijöiden palkkoja
            employees[0].CompareSalary(employees[1]);
            employees[1].CompareSalary(employees[2]);
            employees[0].CompareSalary(employees[2]);

            Console.ReadKey();
        }
    }
}
