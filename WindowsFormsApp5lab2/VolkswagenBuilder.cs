using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5lab2
{
    abstract class VolkswagenBuilder
    {
        public abstract void SetEngine();
        public abstract void SetEngineCapacity();
        public abstract void SetAntilockBrakingSystem();
        public abstract void SetElectronicStabilizationSystem();
        public abstract void SetCountofAirbags();
        public abstract void SetOnboardComputer();
        public abstract void SetConditionerOrClimateControl();
        public abstract void SetInteriorTrim();
        public abstract  Volkswagen GetProduct();


    }
}
