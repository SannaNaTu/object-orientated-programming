using System;

namespace CarTask

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Vehicle vehicle1 = new Cars();

            Console.WriteLine(vehicle1.VehicleInfo());

            Cars cars1 = new Cars();
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

            Console.ReadKey();
        }
    }
}
