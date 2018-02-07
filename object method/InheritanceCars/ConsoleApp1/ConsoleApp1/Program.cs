using System;

namespace CarTask

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Vehicle vehicle1 = new Vehicle();
            Console.WriteLine(vehicle1.VehicleInfo());
            Cars cars1 = new Cars();
            Console.WriteLine(cars1.VehicleInfo());
            Console.WriteLine(vehicle1);
            Console.ReadKey();
        }
    }
}
