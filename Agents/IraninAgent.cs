using SensorStrike.Sensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorStrike.Agents
{
    public abstract class IraninAgent
    {
        protected List<ISensor> weaknesses;
        protected List<ISensor> attachedSensors;

        public IraninAgent(List<ISensor> weak)
        {
            weaknesses = weak;
            attachedSensors = new List<ISensor>();
        }

        public virtual void AttachSensor(ISensor sensor)
        {
            
            if (sensor.IsActive)
            {
                attachedSensors.Add(sensor);
                sensor.Activate();
            }
        }

        public virtual string GetActiveResult()
        {
            int correctMatches = 0;
            List<ISensor> temp = new List<ISensor>(weaknesses);

            foreach (ISensor sensor in attachedSensors)
            {
                var match = temp.FirstOrDefault(w => w.Name == sensor.Name);
                if (match != null)
                {
                    correctMatches++;
                    temp.Remove(match);
                }

            }
            return $"{correctMatches}/{weaknesses.Count}";
        }
        public bool IsExposed()
        {
            return GetActiveResult() == $"{weaknesses.Count}/{weaknesses.Count}";
        }

    }

}
