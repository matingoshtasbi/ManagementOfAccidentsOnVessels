using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Services
{
    public interface IVesselsManagementService
    {
        bool IsSerialExist(string serialNumber);
        bool IsPortExist(long portId);
        bool IsPortHaveCapacity(long portId);
    }
}
