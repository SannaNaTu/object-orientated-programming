using System;

namespace TaskCar

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna ohjelmalle automerkki ja nopeus!");
            Car carA = new Car();
            Car carB = new Car();
            carA.AskData();
            carB.AskData();
            Console.WriteLine("Antamasi arvot!"); //näytetään arvot välissä, jotta muutos näkyy
            carA.ShowCarInfo();
            carB.ShowCarInfo();
            carA.Accelerate(100);
            carB.Accelerate(100);
            Console.WriteLine("Lisätty nopeutta 100!");
            carA.ShowCarInfo();
            carB.ShowCarInfo();
            carA.Brake();
            carB.Brake();
            Console.WriteLine("Vähennetty nopeutta 10%!");
            carA.ShowCarInfo();
            carB.ShowCarInfo();
            Console.ReadKey();
        }
    }
}
