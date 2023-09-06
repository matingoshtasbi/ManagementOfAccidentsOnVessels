using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Enums
{
    public enum MissionTypesEnum
    {
        [Display(Name = "سوخت رسانی")]
        Fueling = 1,
        [Display(Name = "جنگ")]
        War = 2,
        [Display(Name = "آتش سوزی")]
        Fire = 3,
        [Display(Name = "آلودگی")]
        Pollution = 4
    }
}
