using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Domain.Missions.ParameterObjects
{
    public class SuggestedVesselPO
    {
        public SuggestedVesselPO(string name, decimal maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }

        public string Name { get; set; }
        public decimal MaxSpeed { get; set; }
        public decimal Duration { get; set; }
        public string PortName { get; set; }

        internal void MeasureDuration(decimal distance , string portName)
        {
            Duration = distance / MaxSpeed;
            PortName = portName;
        }
    }
}
