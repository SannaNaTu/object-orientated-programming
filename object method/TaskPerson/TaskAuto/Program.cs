using System;

namespace TaskCar

{
    class Program
    {
        static void Main(string[] args)
        {
            Car carA = new Car();
            carA.AskData();
            //Console.WriteLine();
            carA.ShowCarInfo();

            carA.Accelerate();

            carA.Break();

            Console.ReadKey();
        }
    }
}
