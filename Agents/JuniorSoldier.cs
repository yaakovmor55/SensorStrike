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
        public JuniorSoldier() : base(GenerateWeaknesses(2)) { }

        private static List<ISensor> GenerateWeaknesses(int NumOfWeakness)
        {
            List<ISensor> Weaknesses = new List<ISensor>();
            for (int i = 0; i < NumOfWeakness; i++)
            {
                Weaknesses.Add(SensorFactory.CreateRandomSensor());
            }
            return Weaknesses;
        }
    }
}
