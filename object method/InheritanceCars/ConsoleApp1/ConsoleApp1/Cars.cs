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

        public Cars() :base()
        {
            EngineSize = 15;
            EngineModel = 20;
            DoorCount = 5;

        }
        public Cars(int engineSize, int engineModel, int doorCount) :base()
        {
            EngineSize = engineSize;
            EngineModel = engineModel;
            DoorCount = doorCount;

        }
        public override string VehicleInfo()
        {
            base.VehicleInfo();
            return $"Moottorin koko: {EngineSize}, moottorin merkki: {EngineModel},ovien lkm: {DoorCount} kpl.";
        }
    }
}
