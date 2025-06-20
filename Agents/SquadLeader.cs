﻿using SensorStrike.Factories;
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
        private static Random Rand = new Random();
        private int turnCount = 0;
        public SquadLeader() : base (GenerateWeaknesses(4)) { }

        public static List<ISensor> GenerateWeaknesses(int NumOfWeakness)
        {
            List<ISensor> Weaknesses = new List<ISensor>();
            for (int i = 0; i < NumOfWeakness; i++)
            {
                Weaknesses.Add(SensorFactory.CreateRandomSensor());
            }
            return Weaknesses;
        }

        public override void AttachSensor(ISensor sensor)
        {
            if (sensor.IsActive)
            {
                attachedSensors.Add(sensor);
                sensor.Activate();
                turnCount++;

                Console.WriteLine($"[Turn {turnCount}] Sensor {sensor.Name}");

                if(turnCount %3 == 0)
                {
                    AttackBack();
                }
            }
        }

        private void AttackBack()
        {
            if(attachedSensors.Count == 0)
            {
                Console.WriteLine("Agent tried to counter - attack, but has no sensors to remove.");
                return;
            }
            int index = Rand.Next(attachedSensors.Count);
            ISensor removed = attachedSensors[index];
            attachedSensors.RemoveAt(index);

            Console.WriteLine($"Counter-attack! Agent removed sensor: {removed.Name}");
        }
    }
    
}
