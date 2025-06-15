using SensorStrike.Factories;
using SensorStrike.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorStrike.Agents
{
    internal class JuniorSoldier : IraninAgent
    {
        public JuniorSoldier() : base(GenerateWeaknesses()) { }

        private static List<ISensor> GenerateWeaknesses()
        {
            //return new List<ISensor>
            //{new BasicSensor("Thermal"),
            //  new BasicSensor("Audio")
            //};
            return new List<ISensor>() { SensorFactory.CreateRandomSensor(), SensorFactory.CreateRandomSensor() };
        }
    }
}
