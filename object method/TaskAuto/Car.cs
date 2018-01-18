using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCar

{
    class Car
    {
        public string Brand;
        public double Speed;

        //public Car(string brand, int speed)
        //{
        //    Brand = brand;
        //    Speed = speed;
        //}
        public void AskData()
        {
            Console.Write("Auton malli: ");
            Brand = Console.ReadLine();
            Console.Write("Auton nopeus: ");
            Speed = int.Parse(Console.ReadLine());
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Merkki: {Brand}\nNopeus: {Speed}");
        }
        public void Accelerate(double speed)
        {
            if (speed >= 0)
                Speed += speed;
        }

        public void Brake()
        {
            Speed =( Speed /10) * 9;
        }
    }
}
