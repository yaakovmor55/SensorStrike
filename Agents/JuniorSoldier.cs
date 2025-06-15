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

        private static List<string> GenerateWeaknesses()
        {
            return new List<string> { "Thermal", "Audio" };
        }
    }
}
