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
        protected List<string> weaknesses;
        protected List<ISensor> attachedSensors;

        public IraninAgent(List<string> weak)
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
            List<string> temp = new List<string>(weaknesses);

            foreach (ISensor sensor in attachedSensors)
            {
                if (temp.Contains(sensor.Name))
                {
                    correctMatches++;
                    temp.Remove(sensor.Name);
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
