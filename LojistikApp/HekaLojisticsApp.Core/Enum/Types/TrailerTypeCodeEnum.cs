using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HekaLojisticsApp.Core.Enum.Types
{
    public enum TrailerTypeCodeEnum
    {
        //Romörk 
        [Display(Name = "Çadırlı")]
        Cadirli = 0,

        [Display(Name = "Frigo")]
        Frigo = 0,

        [Display(Name = "Kapalı")]
        Kapali = 0,

    }
}
