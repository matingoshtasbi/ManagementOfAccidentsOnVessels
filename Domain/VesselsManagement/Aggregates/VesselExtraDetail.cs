using ManagementOfAccidentsOnVessels.Domain.VesselsManagement.ParameterObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Aggregates
{
    [ComplexType]
    public class VesselExtraDetail
    {
        public VesselExtraDetail()
        {

        }
        public VesselExtraDetail(VesselExtraDetailPO detailPO)
        {
            EngineModel = detailPO.EngineModel;
            ManufacturerCountry = detailPO.ManufacturerCountry;
            ManufacturerName = detailPO.ManufacturerName;
            Capacity = detailPO.Capacity;
            BodyMaterial = detailPO.BodyMaterial;
        }

        public string EngineModel { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerCountry { get; set; }
        public int? Capacity { get; set; }
        public string BodyMaterial { get; set; }
    }
}
