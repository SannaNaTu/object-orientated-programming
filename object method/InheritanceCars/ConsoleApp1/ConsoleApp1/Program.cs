﻿using System;

namespace CarTask

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Vehicle vehicle1 = new Cars();


            Console.WriteLine(vehicle1.VehicleInfo());

            Cars cars1 = new Cars("Nissan","Sunny",1845,65000,34,1234,2);
            Console.WriteLine(cars1.VehicleInfo());
            //vehicle1.VehicleInfo();
            //cars1.VehicleInfo();
            //Console.WriteLine(vehicle1.VehicleInfo());
            //Console.WriteLine(cars1.VehicleInfo());

            Trucks trucks = new Trucks();
            Console.WriteLine(trucks.CountDiesel());
            Console.WriteLine();

            Cars car2 = (Cars) trucks;
            Console.WriteLine(car2.VehicleInfo());


            Trucks truck2 = (Trucks)car2;
            Console.WriteLine(truck2.VehicleInfo());
            Console.WriteLine("To.String-testi");
            Console.WriteLine(car2.ToString());
            Console.WriteLine("Equals(obj, obj}-metodit");  
            Console.WriteLine(cars1.Equals(cars1));
            Console.WriteLine(cars1.Equals(car2));

            Console.ReadKey();
        }
    }
}
