using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5lab2
{
    class VolkswagenPassat: VolkswagenBuilder
    {
        private Volkswagen Volkswagen2 = new Volkswagen();
        public override void SetEngine()
        {
            Volkswagen2.Add("бензин");
        }
        public override void SetEngineCapacity()
        {
            Volkswagen2.Add("1890 см3");
        }
        public override void SetAntilockBrakingSystem()
        {
            Volkswagen2.Add("присутня");
        }
        public override void SetElectronicStabilizationSystem()
        {
            Volkswagen2.Add("відсутня");
        }
        public override void SetCountofAirbags()
        {
            Volkswagen2.Add("десять");
        }
        public override void SetOnboardComputer()
        {
            Volkswagen2.Add("немає");
        }
        public override void SetConditionerOrClimateControl()
        {
            Volkswagen2.Add("кондиціонер");
        }
        public override void SetInteriorTrim()
        {
            Volkswagen2.Add("світла");
        }
        public override Volkswagen GetProduct()
        {
            return Volkswagen2;
        }
    }
}
