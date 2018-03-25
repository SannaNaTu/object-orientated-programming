using System;
using System.Collections.Generic;
using System.Text;

namespace CarTask
{

    class Cars : Vehicle
    {
        protected int EngineSize;
        protected int EngineModel;
        protected int DoorCount;

        public Cars()
        {
            EngineSize = 15;
            EngineModel = 20;
            DoorCount = 5;

        }

        public Cars(string type, string model, int year, int price) : base(type, model, year, price)
        {
        }

        public Cars(string type, string model, int year, int price, int engineSize, int engineModel, int doorCount)
        {
            Type = type;
            Model = model;
            Year = year;
            Price = price;
            EngineSize = engineSize;
            EngineModel = engineModel;
            DoorCount = doorCount;

        }
        public override string VehicleInfo()
        {
           return $"{base.VehicleInfo()} Moottorin koko: {EngineSize}, moottorin merkki: {EngineModel},ovien lkm: {DoorCount} kpl.";
        }

    
        public override string ToString()
        {
            return ($"\n{EngineSize}\n{EngineModel}\n{DoorCount}\n");
        }
        public override bool Equals(object obj)
        {
            Cars carObj = obj as Cars;
            if (carObj == null)
                return false;
            else
                return Model.Equals(carObj.Model);
        }





    }
}
