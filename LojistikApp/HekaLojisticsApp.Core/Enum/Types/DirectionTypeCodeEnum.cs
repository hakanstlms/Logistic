using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HekaLojisticsApp.Core.Enum.Types
{
    public enum DirectionTypeCodeEnum
    {
        [Display(Name = "Sağ Ön Dış")]
        SOND = 0,

        [Display(Name = "Sol Ön Dış")]
        SLOND = 1,

        [Display(Name = "Sağ Ön İç")]
        SONI = 2,

        [Display(Name = "Sol Ön İç")]
        SLONI = 3,

        [Display(Name = "Sağ Orta Dış")]
        SORD = 4,

        [Display(Name = "Sol Orta Dış")]
        SLORD = 5,

        [Display(Name = "Sağ Orta İç")]
        SORI = 6,

        [Display(Name = "Sol Orta İç")]
        SLORI = 7,

        [Display(Name = "Sağ Arka Dış")]
        SAD = 8,

        [Display(Name = "Sol Arka Dış")]
        SLAD = 9,

        [Display(Name = "Sağ Arka İç")]
        SAI = 10,

        [Display(Name = "Sol Arka İç")]
        SLAI = 11,

    }
}
