using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5lab2
{
    class VolkswagenPolo: VolkswagenBuilder
    {
        private Volkswagen Volkswagen3 = new Volkswagen();
        public override void SetEngine()
        {
            Volkswagen3.Add("бензиновий");
        }
        public override void SetEngineCapacity()
        {
            Volkswagen3.Add("1560 см3");
        }
        public override void SetAntilockBrakingSystem()
        {
            Volkswagen3.Add("відсутня");
        }
        public override void SetElectronicStabilizationSystem()
        {
            Volkswagen3.Add("присутня");
        }
        public override void SetCountofAirbags()
        {
            Volkswagen3.Add("шість");
        }
        public override void SetOnboardComputer()
        {
            Volkswagen3.Add("немає");
        }
        public override void SetConditionerOrClimateControl()
        {
            Volkswagen3.Add("кондиціонер");
        }
        public override void SetInteriorTrim()
        {
            Volkswagen3.Add("чорна");
        }
        public override Volkswagen GetProduct()
        {
            return Volkswagen3;
        }
    }
}
