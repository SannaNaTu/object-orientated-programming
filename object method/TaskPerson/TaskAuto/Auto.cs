using System;
using System.Collections.Generic;
using System.Text;

namespace TaskCar

{
    class Car
    {
        public string Brand;
        public double Speed;
    }
    public Car()
    {
        Brand = "";
        Speed = "";
    }
    public Car(string brand, double speed)
    {
        brand = brand;
        speed = speed;
    }
    public void ShowCarInfo()
    {
        Console.WriteLine($"Merkki: {Brand}\nNopeus: {Speed}");
    }
}
