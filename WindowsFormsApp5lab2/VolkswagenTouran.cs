using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5lab2
{
    class VolkswagenTouran: VolkswagenBuilder
    {
        private Volkswagen Volkswagen4 = new Volkswagen();
        public override void SetEngine()
        {
            Volkswagen4.Add("дизельний");
        }
        public override void SetEngineCapacity()
        {
            Volkswagen4.Add("2100 см3");
        }
        public override void SetAntilockBrakingSystem()
        {
            Volkswagen4.Add("присутня");
        }
        public override void SetElectronicStabilizationSystem()
        {
            Volkswagen4.Add("присутня");
        }
        public override void SetCountofAirbags()
        {
            Volkswagen4.Add("дванадцять");
        }
        public override void SetOnboardComputer()
        {
            Volkswagen4.Add("наявний");
        }
        public override void SetConditionerOrClimateControl()
        {
            Volkswagen4.Add("клімат-контроль");
        }
        public override void SetInteriorTrim()
        {
            Volkswagen4.Add("світла");
        }
        public override Volkswagen GetProduct()
        {
            return Volkswagen4;
        }
      
    }
}
