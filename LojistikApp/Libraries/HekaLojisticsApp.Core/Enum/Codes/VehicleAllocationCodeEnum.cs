using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HekaLojisticsApp.Core.Enum.Codes
{
    public enum VehicleAllocationCodeEnum
    {
        [Display(Name = "Satın Alma")]
        SA = 0,

        [Display(Name = "Kiralık")]
        K = 0,
    }
}
