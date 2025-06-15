using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorStrike.Sensors
{
    public interface ISensor
    {
        
        string Name { get; }
        bool IsActive { get; }
        void Activate();
    
    
    }
}
