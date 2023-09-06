using ManagementOfAccidentsOnVessels.Application.VesselsManagement.DTO;
using ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Aggregates;
using ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Enums;
using ManagementOfAccidentsOnVessels.Domain.VesselsManagement.ParameterObjects;
using ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Services;
using ManagementOfAccidentsOnVessels.Infrastructure.DataBaseContext;
using ManagementOfAccidentsOnVessels.Infrastructure.Utilities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Application.VesselsManagement
{
    public class CommandQueryVesselService : ICommandQueryVesselService
    {
        private readonly IVesselsManagementService _vesselsManagementService;
        private readonly ManagementOfAccidentsOnVesselsDbContext _context;
        public CommandQueryVesselService(IVesselsManagementService vesselsManagementService,
            ManagementOfAccidentsOnVesselsDbContext context)
        {
            _vesselsManagementService = vesselsManagementService;
            _context = context;
        }

        #region command
        public void AddVessel(AddVesselDTO dto)
        {
            // Map Vessel DTO To PO
            VesselPO po = new VesselPO()
            {
                Name = dto.Name,
                MaxSpeed = dto.MaxSpeed,
                SerialNumber = dto.SerialNumber,
                PortId = dto.PortId,
                VesselTypeId = dto.VesselTypeId
            };

            // Create Instance
            var vessel = VesselFactory.CreateVessel(po, _vesselsManagementService);

            if (dto.Detail != null)
            {
                // Map ED DTO To PO
                VesselExtraDetailPO detailPO = new VesselExtraDetailPO()
                {
                    BodyMaterial = dto.Detail.BodyMaterial,
                    Capacity = dto.Detail.Capacity,
                    EngineModel = dto.Detail.EngineModel,
                    ManufacturerCountry = dto.Detail.ManufacturerCountry,
                    ManufacturerName = dto.Detail.ManufacturerName
                };

                // Add VesselExtraDetail
                vessel.AddOrUpdateDetail(detailPO);
            }

            // Add To DB
            _context.Vessels.Add(vessel);

            // Save Record
            _context.SaveChanges();
        }

        public void UpdateVessel(UpdateVesselDTO dto)
        {
            // Get Vessel
            var vessel = _context.Vessels.FirstOrDefault(x => x.Id == dto.Id);
            if (vessel == null)
                throw new Exception("شناور یافت نشد");

            // Add Service and Create PO
            vessel.VesselService = _vesselsManagementService;
            var po = new VesselPO()
            {
                Id = dto.Id,
                IsActive = dto.IsActive,
                MaxSpeed = dto.MaxSpeed,
                Name = dto.Name,
                PortId = dto.PortId,
                SerialNumber = dto.SerialNumber,
                VesselTypeId = dto.VesselTypeId
            };

            // Update Vessel
            vessel.UpdateProperties(po);

            if (dto.Detail != null)
            {
                // Map ED DTO To PO
                VesselExtraDetailPO detailPO = new VesselExtraDetailPO()
                {
                    BodyMaterial = dto.Detail.BodyMaterial,
                    Capacity = dto.Detail.Capacity,
                    EngineModel = dto.Detail.EngineModel,
                    ManufacturerCountry = dto.Detail.ManufacturerCountry,
                    ManufacturerName = dto.Detail.ManufacturerName
                };

                // Update VesselExtraDetail
                vessel.AddOrUpdateDetail(detailPO);
            }

            // Save Changes
            _context.SaveChanges();
        }

        public void DeleteVessel(long id)
        {
            // Get Vessel
            var vessel = _context.Vessels.FirstOrDefault(x => x.Id == id);
            if (vessel == null)
                throw new Exception("شناور یافت نشد");

            _context.Vessels.Remove(vessel);
            _context.SaveChanges();
        }
        #endregion

        #region query
        public List<VesselDTO> GetAllVessels()
        {
            var dataModel = _context.Vessels.AsNoTracking().ToList();
            var result = new List<VesselDTO>();
            foreach (var item in dataModel)
            {
                var port = _context.Ports.FirstOrDefault(x => x.Id == item.PortId);

                var vesselTypeEnum = (VesselTypesEnum)item.VesselTypeId;
                var vesselTypeName = vesselTypeEnum.GetAttribute<DisplayAttribute>().Name!;


                result.Add(new VesselDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    IsActive = item.IsActive,
                    MaxSpeed = item.MaxSpeed,
                    Port = port.Name,
                    SerialNumber = item.SerialNumber,
                    VesselType = vesselTypeName
                });
            }
            return result;
        }

        public VesselDTO GetVessel(long id)
        {
            var dataModel = _context.Vessels.FirstOrDefault(c => c.Id == id);

            var port = _context.Ports.FirstOrDefault(x => x.Id == dataModel.PortId);

            var vesselTypeEnum = (VesselTypesEnum)dataModel.VesselTypeId;
            var vesselTypeName = vesselTypeEnum.GetAttribute<DisplayAttribute>().Name!;

            var result = new VesselDTO()
            {
                Id = id,
                Name = dataModel!.Name,
                IsActive = dataModel.IsActive,
                MaxSpeed= dataModel.MaxSpeed,
                Port = port!.Name,
                SerialNumber = dataModel.SerialNumber,
                VesselType = vesselTypeName,
                Detail = new VesselExtraDetailDTO()
                {
                    BodyMaterial = dataModel.Detail.BodyMaterial,
                    Capacity = dataModel.Detail.Capacity,
                    EngineModel = dataModel.Detail.EngineModel,
                    ManufacturerCountry = dataModel.Detail.ManufacturerCountry,
                    ManufacturerName = dataModel.Detail.ManufacturerName
                }
            };

            return result;
        }

        public List<VesselTypeDTO> GetAllVesselTypes()
        {
            List<VesselTypeDTO> result = new List<VesselTypeDTO>();

            result.Add(new VesselTypeDTO() { Id = (int)VesselTypesEnum.Stoker, Name = VesselTypesEnum.Stoker.GetAttribute<DisplayAttribute>().Name! });
            result.Add(new VesselTypeDTO() { Id = (int)VesselTypesEnum.Military, Name = VesselTypesEnum.Military.GetAttribute<DisplayAttribute>().Name! });
            result.Add(new VesselTypeDTO() { Id = (int)VesselTypesEnum.Firefighter, Name = VesselTypesEnum.Firefighter.GetAttribute<DisplayAttribute>().Name! });
            result.Add(new VesselTypeDTO() { Id = (int)VesselTypesEnum.PollutionCollector, Name = VesselTypesEnum.PollutionCollector.GetAttribute<DisplayAttribute>().Name! });

            return result;
        }

        #endregion
    }
}
