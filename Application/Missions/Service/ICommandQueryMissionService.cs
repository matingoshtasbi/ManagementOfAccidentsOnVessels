using ManagementOfAccidentsOnVessels.Application.Missions.DTO;
using ManagementOfAccidentsOnVessels.Domain.Missions.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Application.Missions.Service
{
    public interface ICommandQueryMissionService
    {
        List<MissionTypeDTO> GetAllMissionTypes();
        MissionResultDTO MissionSuggest(MissionDTO missionDTO);
    }
}
