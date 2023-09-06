using ManagementOfAccidentsOnVessels.Application.Missions.DTO;
using ManagementOfAccidentsOnVessels.Domain.Missions.Aggregates;
using ManagementOfAccidentsOnVessels.Domain.Missions.ParameterObjects;
using ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Enums;
using ManagementOfAccidentsOnVessels.Infrastructure.DataBaseContext;
using ManagementOfAccidentsOnVessels.Infrastructure.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Application.Missions.Service
{
    public class CommandQueryMissionService : ICommandQueryMissionService
    {
        private readonly ManagementOfAccidentsOnVesselsDbContext _context;
        public CommandQueryMissionService(ManagementOfAccidentsOnVesselsDbContext context)
        {
            _context = context;
        }
        public List<MissionTypeDTO> GetAllMissionTypes()
        {
            List<MissionTypeDTO> result = new List<MissionTypeDTO>();

            result.Add(new MissionTypeDTO() { Id = (int)MissionTypesEnum.Fueling, Name = MissionTypesEnum.Fueling.GetAttribute<DisplayAttribute>().Name! });
            result.Add(new MissionTypeDTO() { Id = (int)MissionTypesEnum.War, Name = MissionTypesEnum.War.GetAttribute<DisplayAttribute>().Name! });
            result.Add(new MissionTypeDTO() { Id = (int)MissionTypesEnum.Fire, Name = MissionTypesEnum.Fire.GetAttribute<DisplayAttribute>().Name! });
            result.Add(new MissionTypeDTO() { Id = (int)MissionTypesEnum.Pollution, Name = MissionTypesEnum.Pollution.GetAttribute<DisplayAttribute>().Name! });

            return result;
        }

        public MissionResultDTO MissionSuggest(MissionDTO missionDTO)
        {
            var po = new MissionPO()
            {
                Lat = missionDTO.Lat,
                Lon = missionDTO.Lon,
                MissionTypeId = missionDTO.MissionTypeId
            };

            if (!Enum.IsDefined(typeof(MissionTypesEnum), missionDTO.MissionTypeId))
                throw new Exception("نوع ماموریت یافت نشد");

            var suggestedVessels = _context.Vessels.Where(c => c.VesselTypeId == po.MissionTypeId && c.IsActive == true).ToList();

            if (!suggestedVessels.Any())
                throw new Exception("شناور فعالی برای این ماموریت یافت نشد");

            var candidateVesselsPorts = _context.Ports.Where(c => suggestedVessels.Select(s => s.PortId).Contains(c.Id)).Distinct().ToList();

            po.PortVessels = new List<PortVesselPO>();

            foreach (var port in candidateVesselsPorts)
            {
                var portVessel = new PortVesselPO(port.Name, port.Lat, port.Lon, suggestedVessels.Where(c => c.PortId == port.Id));

                portVessel.MeasureDistanceAndDuration(po.Lat, po.Lon);

                po.PortVessels.Add(portVessel);
            }

            // GetResult
            var bestVessel = po.PortVessels.SelectMany(c => c.Vessels).Aggregate((curMin, x) => (x.Duration < curMin.Duration ? x : curMin));

            var result = new MissionResultDTO()
            {
                Duration = bestVessel.Duration,
                VesselName = bestVessel.Name,
                PortName = bestVessel.PortName,
            };

            return result;
        }
    }
}
