using System;
using System.Collections.Generic;
using SensorStrike.Sensors;

namespace SensorStrike.Factories
{
    public static class SensorFactory
    {
        private static readonly List<string> SensorTypes = new List<string>
        {
            "Thermal",
            "Audio",
            "Pulse"

        };

        private static readonly Random rand = new Random();

        public static List<string> GetAvailableSensorTypes()
        {
            return SensorTypes;
        }

        public static ISensor CreateSensor(string name)
        {
            return name switch
            {
                "Thermal" => new BasicSensor("Thermal"),
                "Audio" => new BasicSensor("Audio"),
                "Pulse" => new PulseSensor("Pulse"),
                _ => throw new ArgumentException($"Unknown sensor type: {name}")
            };
        }

        public static ISensor CreateRandomSensor()
        {
            string name = SensorTypes[rand.Next(SensorTypes.Count)];
            return CreateSensor(name);
        }
    }
}
