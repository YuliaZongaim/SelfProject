using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5lab2
{
    class Director
    {
        public void Construct(VolkswagenBuilder builder)
        {
            builder.SetEngine();
            builder.SetEngineCapacity();
            builder.SetAntilockBrakingSystem();
            builder.SetElectronicStabilizationSystem();

            builder.SetCountofAirbags();
            builder.SetOnboardComputer();
            builder.SetConditionerOrClimateControl();
            builder.SetInteriorTrim();

        }
    }
}

