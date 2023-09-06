using ManagementOfAccidentsOnVessels.Infrastructure.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Services
{
    public class VesselsManagementService : IVesselsManagementService
    {
        #region members
        private readonly ManagementOfAccidentsOnVesselsDbContext _context;
        #endregion

        #region constractors
        public VesselsManagementService(ManagementOfAccidentsOnVesselsDbContext context)
        {
            _context = context;
        }

        #endregion

        #region public methods
        public bool IsSerialExist(string serialNumber)
        {
            return _context.Vessels.Where(v => v.SerialNumber == serialNumber).Any();
        }
        public bool IsPortExist(long portId)
        {
            return _context.Ports.Where(v => v.Id == portId).Any();
        }

        public bool IsPortHaveCapacity(long portId)
        {
            var port = _context.Ports.FirstOrDefault(c => c.Id == portId);
            var vesselsCount = _context.Vessels.Where(v => v.PortId == portId).Count();
            if (port!.Capacity <= vesselsCount)
                return false;

            return true;
        }
        #endregion
    }
}
