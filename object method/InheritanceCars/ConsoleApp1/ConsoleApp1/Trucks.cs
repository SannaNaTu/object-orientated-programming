using System;
using System.Collections.Generic;
using System.Text;

namespace CarTask
{
    class Trucks : Cars
    {
        protected int loadWeight;
        protected int dieselPerKg;

        public Trucks()
        {
            loadWeight = 3000;
            dieselPerKg = 20;
        }
        
        public Trucks (int LoadWeight, int DieselPerKg, int engineSize, int engineModel, int doorCount)
        {
            loadWeight = LoadWeight;
            dieselPerKg = DieselPerKg;
            EngineSize = engineSize;
            EngineModel = engineModel;
            DoorCount = doorCount;
        }
        public string CountDiesel()
        {
            return $"Kulutus on:{loadWeight * dieselPerKg} \n" +
                    $"---------------------";
        }

        public new string VehicleInfo()
        {
            return $"{CountDiesel()}";
        }


    }
}
