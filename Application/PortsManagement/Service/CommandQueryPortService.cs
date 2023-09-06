using ManagementOfAccidentsOnVessels.Application.PortsManagement.DTO;
using ManagementOfAccidentsOnVessels.Infrastructure.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Application.PortsManagement.Service
{
    public class CommandQueryPortService : ICommandQueryPortService
    {
        private readonly ManagementOfAccidentsOnVesselsDbContext _context;
        public CommandQueryPortService(ManagementOfAccidentsOnVesselsDbContext context)
        {
            _context = context;
        }

        public List<PortComboDTO> GetAllPorts()
        {
            List<PortComboDTO> result = new List<PortComboDTO>();
            var ports = _context.Ports.AsNoTracking().ToList();
            foreach (var item in ports)
            {
                result.Add(new PortComboDTO() { Id = item.Id, Name = item.Name });
            }

            return result;
        }
    }
}
