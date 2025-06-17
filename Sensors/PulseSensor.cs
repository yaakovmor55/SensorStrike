using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SensorStrike.Sensors
{
    internal class PulseSensor : ISensor
    {
        public string Name { get; private set; } = "Pulse";
        public bool IsActive { get; private set; } = true;

        private static int ActivCont = 0;

        public PulseSensor(string name)
        {
            Name = name;
        }

        public void Activate()
        {
            ActivCont ++;
            if (ActivCont > 3)
            {
                IsActive = false;
                Console.WriteLine($"{Name} has broken after 3 activations");
            }
            else
            {
                Console.WriteLine($"{Name} sensor activated ({ActivCont}/3).");
            }
        }
    }
}
