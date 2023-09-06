using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Application.VesselsManagement.DTO
{
    public class VesselDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal MaxSpeed { get; set; }
        public string VesselType { get; set; }
        public string SerialNumber { get; set; }
        public string Port { get; set; }
        public bool IsActive { get; set; }

        // Detail
        public VesselExtraDetailDTO Detail { get; set; }
    }
}
