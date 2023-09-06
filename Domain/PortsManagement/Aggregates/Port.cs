using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Domain.PortsManagement.Aggregates
{
    public class Port
    {
        public Port()
        {

        }

        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public int Capacity { get; set; }
    }
}
