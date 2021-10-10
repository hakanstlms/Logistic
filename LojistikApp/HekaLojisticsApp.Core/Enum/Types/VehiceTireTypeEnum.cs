using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HekaLojisticsApp.Core.Enum.Types
{
    public enum VehiceTireTypeEnum
    {
        [Display(Name = "Yazlık")]
        Yazlik = 0,

        [Display(Name = "Kışlık")]
        Kislik = 1,
    }
}
