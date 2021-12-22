using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5lab2
{
    class VolkswagenGolf : VolkswagenBuilder
    {
        private Volkswagen Volkswagen1 = new Volkswagen();
        public override void SetEngine()
        {
            Volkswagen1.Add("бензиновий");
        }
        public override void SetEngineCapacity()
        {
            Volkswagen1.Add("1984 см3");
        }
        public override void SetAntilockBrakingSystem()
        {
            Volkswagen1.Add("присутня");
        }
        public override void SetElectronicStabilizationSystem()
        {
            Volkswagen1.Add("присутня");
        }
        public override void SetCountofAirbags()
        {
            Volkswagen1.Add("сім");
        }
        public override void SetOnboardComputer()
        {
            Volkswagen1.Add("немає");
        }
        public override void SetConditionerOrClimateControl()
        {
            Volkswagen1.Add("кондиціонер");
        }
        public override void SetInteriorTrim()
        {
            Volkswagen1.Add("чорна");
        }
        public override Volkswagen GetProduct()
        {
            return Volkswagen1;
        }
    }
}
