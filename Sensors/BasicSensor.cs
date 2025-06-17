using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorStrike.Sensors
{
    internal class BasicSensor : ISensor
    {
        public string Name { get; private set; }
        public bool IsActive {  get; private set; } = true;

        public BasicSensor(string name)
        {
            Name = name;
        }

        
        public void Activate()
        {
            
        }
    }
}
