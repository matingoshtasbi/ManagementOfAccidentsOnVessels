using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Domain.VesselsManagement.ParameterObjects
{
    public class VesselExtraDetailPO
    {
        public string EngineModel { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerCountry { get; set; }
        public int? Capacity { get; set; }
        public string BodyMaterial { get; set; }
    }
}
