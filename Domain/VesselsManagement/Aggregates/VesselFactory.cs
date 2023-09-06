using ManagementOfAccidentsOnVessels.Domain.VesselsManagement.ParameterObjects;
using ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Aggregates
{
    public static class VesselFactory
    {
        internal static Vessel CreateVessel(VesselPO po, IVesselsManagementService _vesselsManagementService)
        {
            return new Vessel(po , _vesselsManagementService);
        }
    }
}
