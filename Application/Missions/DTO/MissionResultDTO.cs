using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Domain.Missions.Aggregates
{
    public class MissionResultDTO
    {
        public string PortName { get; set; }
        public string VesselName { get; set; }
        public decimal Duration { get; set; }
    }
}
