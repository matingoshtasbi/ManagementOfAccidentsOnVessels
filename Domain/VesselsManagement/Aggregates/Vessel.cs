using ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Enums;
using ManagementOfAccidentsOnVessels.Domain.VesselsManagement.ParameterObjects;
using ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Aggregates
{
    public class Vessel
    {
        #region constractor
        public Vessel()
        {

        }
        public Vessel(VesselPO po, IVesselsManagementService vesselsManagementService)
        {
            VesselService = vesselsManagementService;
            Validate(po);
            SerialNumber = po.SerialNumber;
            Name = po.Name;
            MaxSpeed = po.MaxSpeed;
            VesselTypeId = po.VesselTypeId;
            PortId = po.PortId;
            IsActive = true;
        }
        #endregion

        #region properties
        public long Id { get; set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public decimal MaxSpeed { get; set; }
        public int VesselTypeId { get; set; }
        public long PortId { get; set; }
        public bool IsActive { get; set; }

        public VesselExtraDetail Detail { get; set; }

        public IVesselsManagementService VesselService = default!;


        #endregion

        #region public methods
        public void AddOrUpdateDetail(VesselExtraDetailPO detailPO)
        {
            if (detailPO.Capacity != null && detailPO.Capacity <= 0)
                throw new Exception("تعداد خدمه ی شناور مساوی کوچکتر از صفر نمیتواند باشد");

            Detail = new VesselExtraDetail(detailPO);
        }

        public void UpdateProperties(VesselPO po)
        {
            Validate(po, true);
            SerialNumber = po.SerialNumber;
            Name = po.Name;
            MaxSpeed = po.MaxSpeed;
            VesselTypeId = po.VesselTypeId;
            PortId = po.PortId;
            IsActive = po.IsActive;
        }
        #endregion

        #region private methods
        private void Validate(VesselPO po, bool isUpdate = false)
        {

                // SerialNumber validate
            if (isUpdate)
            {
                if (SerialNumber != po.SerialNumber && VesselService.IsSerialExist(po.SerialNumber))
                    throw new Exception("سریال شناور تکراریست");
            }
            else
            {
                if (VesselService.IsSerialExist(po.SerialNumber))
                    throw new Exception("سریال شناور تکراریست");

                // check Port Capacity
                if (!VesselService.IsPortHaveCapacity(po.PortId))
                    throw new Exception("بندر مورد نظر ظرفیتش تکمیل است");
            }

            // speed validate
            if (po.MaxSpeed <= 0)
                throw new Exception("سرعت شناور نمیتواند کوچکتر یا مساوی صفر باشد");

            // vesselType validate
            if (!Enum.IsDefined(typeof(VesselTypesEnum), po.VesselTypeId))
                throw new Exception("نوع شناور یافت نشد");

            // portId validate
            if (!VesselService.IsPortExist(po.PortId))
                throw new Exception("بندر شناور یافت نشد");




        }
        #endregion
    }
}
