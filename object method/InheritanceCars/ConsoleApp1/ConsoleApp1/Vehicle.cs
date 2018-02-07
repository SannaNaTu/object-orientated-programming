﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarTask

{
    class Vehicle
    {
        protected string Type;
        protected string Model;
        protected int Year;
        protected int Price;

        public Vehicle()
        {
            Type = "Ford";
            Model = "Fiesta";
            Year = 1999;
            Price = 10000;
        }
        public Vehicle ( string type, string model, int year, int price)
        {
            Type = type;
            Model = model;
            Year = year;
            Price = price;
        }
        public virtual string VehicleInfo()
        {
            return $"Tyyppi: {Type}, merkki: {Model},vuosimalli: {Year} ja hinta: {Price}€";
        }
    }
}
