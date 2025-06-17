using SensorStrike.Agents;
using SensorStrike.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorStrike
{
    public class InvestigationManager
    {
        private IraninAgent agent;


        public InvestigationManager()
        {
            agent = new SquadLeader();
        }

        public  void Start()
        {
            Console.WriteLine("Beginning of investigation of Iranian agent");
            while (!agent.IsExposed())
            {
                Console.WriteLine("Chois Sensor (Thermal / Audio / Pulse):");
                string UserInput = Console.ReadLine();

                if (UserInput == "Thermal" || UserInput == "Audio")
                {
                    ISensor sensor = new BasicSensor(UserInput);
                    agent.AttachSensor(sensor);
                }
                else if (UserInput == "Pulse")
                {
                    ISensor pulse = new PulseSensor(UserInput);
                    agent.AttachSensor(pulse);
                }

                string result = agent.GetActiveResult();
                Console.WriteLine($"Result: {result}");
            }
            Console.WriteLine("The agent was successfully exposed.");

        }
    }
}
