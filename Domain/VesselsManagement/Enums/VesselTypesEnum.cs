using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Enums
{
    public enum VesselTypesEnum
    {
        [Display(Name = "سوخت رسان")]
        Stoker = 1,
        [Display(Name = "نظامی")]
        Military = 2,
        [Display(Name = "آتش نشان")]
        Firefighter = 3,
        [Display(Name = "جمع آور آلودگی")]
        PollutionCollector = 4
    }
}
