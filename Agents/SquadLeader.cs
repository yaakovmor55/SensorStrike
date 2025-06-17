using SensorStrike.Factories;
using SensorStrike.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorStrike.Agents
{
    internal class SquadLeader : IraninAgent
    {
        public SquadLeader() : base (GenerateWeaknesses()) { }

        public static List<ISensor> GenerateWeaknesses()
        {
            return new List<ISensor>() 
            {
                SensorFactory.CreateRandomSensor(),
                SensorFactory.CreateRandomSensor(),
                SensorFactory.CreateRandomSensor(),
                SensorFactory.CreateRandomSensor()
            };
        }

        public static void AttackBack()
        {

        }
    }
    
}
