using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Application.VesselsManagement.DTO
{
    public class UpdateVesselDTO
    {
        public long Id { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public decimal MaxSpeed { get; set; }
        public int VesselTypeId { get; set; }
        public long PortId { get; set; }
        public VesselExtraDetailDTO Detail { get; set; }
        public bool IsActive { get; set; }

    }
}
