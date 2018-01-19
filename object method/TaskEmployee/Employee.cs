using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEmployee
{
    class Employee
    {
        //Fields
        public string Name;
        public int Id;
        public string Position;
        public int Salary; 

        //Constuctor =muodostin
        public Employee(string name, int id, string position, int salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
            Id = id;
        }
        //Methods 
        public void CompareSalary(Employee worker)
        {
                if (Salary < worker.Salary)
                    Console.WriteLine($"{worker.Name} palkka on isompi kuin {Name} palkka!");
                else
                    Console.WriteLine($"{Name} palkka on isompi kuin {worker.Name} palkka!");
            }
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Nimi: {Name}\nTunnus: {Id}\nAsema: {Position}\nPalkka: {Salary}\n"); //En saa €-toimimaan, ei double/int C/F:
        }
    }

}

