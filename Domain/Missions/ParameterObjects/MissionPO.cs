using ManagementOfAccidentsOnVessels.Domain.Missions.ParameterObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Domain.Missions.Aggregates
{
    public class MissionPO
    {
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public int MissionTypeId { get; set; }

        public List<PortVesselPO> PortVessels { get; set; }
    }
}
