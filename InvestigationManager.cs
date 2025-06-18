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
            agent = new SeniorCommander();
        }

        public void Start()
        {
            Console.WriteLine($"Beginning of investigation of Iranian agent: {agent.GetType().Name}");

            while (!agent.IsExposed())
            {
                Console.OutputEncoding = Encoding.UTF8;

                Console.WriteLine("Choose a sensor to attach:");
                Console.WriteLine("1. Thermal");
                Console.WriteLine("2. Audio");
                Console.WriteLine("3. Pulse");
                Console.Write("Enter your choice (1-3): ");

                string input = Console.ReadLine();
                int choice;
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("❌ Invalid input. Please enter a number.");
                    continue;
                }

                ISensor sensor;

                switch (choice)
                {
                    case 1:
                        sensor = new BasicSensor("Thermal");
                        break;
                    case 2:
                        sensor = new BasicSensor("Audio");
                        break;
                    case 3:
                        sensor = new PulseSensor("Pulse");
                        break;
                    default:
                        Console.WriteLine("❌ Choice not recognized. Try again.");
                        continue;
                }

                agent.AttachSensor(sensor);

                string result = agent.GetActiveResult();
                Console.WriteLine($"Result: {result}");
            }

            Console.WriteLine("🎯 The agent was successfully exposed.");
        }

    }
}
