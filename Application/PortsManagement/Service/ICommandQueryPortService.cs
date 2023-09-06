using ManagementOfAccidentsOnVessels.Application.PortsManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Application.PortsManagement.Service
{
    public interface ICommandQueryPortService
    {
        List<PortComboDTO> GetAllPorts();
    }
}
