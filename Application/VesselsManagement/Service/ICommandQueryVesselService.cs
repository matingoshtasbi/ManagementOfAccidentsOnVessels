using ManagementOfAccidentsOnVessels.Application.VesselsManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Application.VesselsManagement
{
    public interface ICommandQueryVesselService
    {
        void AddVessel(AddVesselDTO dto);

        void UpdateVessel(UpdateVesselDTO dto);
        void DeleteVessel(long id);
        List<VesselDTO> GetAllVessels();
        List<VesselTypeDTO> GetAllVesselTypes();
        VesselDTO GetVessel(long id);

    }
}
