using ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Domain.Missions.ParameterObjects
{
    public class PortVesselPO
    {

        public PortVesselPO(string name, decimal lat, decimal lon, IEnumerable<Vessel> vessels)
        {
            PortName = name;
            Lat = lat;
            Lon = lon;

            Vessels = new List<SuggestedVesselPO>();
            foreach (var item in vessels)
            {
                Vessels.Add(new SuggestedVesselPO(item.Name, item.MaxSpeed));
            }
        }

        public string PortName { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public decimal Distance { get; set; }

        public List<SuggestedVesselPO> Vessels { get; set; }

        internal void MeasureDistanceAndDuration(decimal lat, decimal lon)
        {
            var calculatedLat = Math.Abs(this.Lat - lat);
            var calculatedLon = Math.Abs(this.Lon - lon);

            Distance = (decimal)Math.Sqrt(Math.Pow((double)calculatedLat, 2) + Math.Pow((double)calculatedLat, 2));

            foreach (var item in Vessels)
            {
                item.MeasureDuration(Distance , PortName);
            }
        }
    }
}
