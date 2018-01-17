using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCar

{
    class Car
    {
        public string Brand;
        public int Speed;
    }
    public void AskData()
    {
        Console.Write("Auton malli: ");
        Brand = Console.ReadLine();
        Console.Write("Auton nopeus: ");
        Speed = int.Parse(Console.ReadLine());
    }
    //public Car()
    //{
    //    Brand = "";
    //    Speed = "";
    //}
    //public Car(string brand, double speed)
    //{
    //    brand = brand;
    //    speed = speed;
    //}
    public void ShowCarInfo()
    {
        Console.WriteLine($"Merkki: {Brand}\nNopeus: {Speed}");
    }
    public void Accelerate(int speed)
    {
        if (speed >= 0)
            Speed += speed;
    }

    public void Brake()
    {
        Speed = Speed * 0.9;
    }
}
