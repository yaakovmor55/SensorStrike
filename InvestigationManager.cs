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
            agent = new JuniorSoldier();
        }

        public  void Start()
        {
            Console.WriteLine("Beginning of investigation of junior Iranian agent");
            while (!agent.IsExposed())
            {
                Console.WriteLine("Chois Sensor (Thermal / Audio):");
                string UserInput = Console.ReadLine();

                ISensor sensor = new BasicSensor(UserInput);
                agent.AttachSensor(sensor);

                string result = agent.GetActiveResult();
                Console.WriteLine($"Result: {result}");
            }
            Console.WriteLine("The agent was successfully exposed.");

        }
    }
}
