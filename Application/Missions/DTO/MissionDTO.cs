using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Application.Missions.DTO
{
    public class MissionDTO
    {
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public int MissionTypeId { get; set; }
    }
}
