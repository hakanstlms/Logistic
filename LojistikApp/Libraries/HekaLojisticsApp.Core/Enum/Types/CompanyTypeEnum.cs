using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HekaLojisticsApp.Core.Enum.Types
{
    public enum  CompanyTypeEnum
    {
        [Display(Name = "Müşteri")]
        Musteri = 0,

        [Display(Name = "Tedarikçi")]
        Tedarikci = 1,

        [Display(Name = "İmalatçı")]
        Imalatci = 2,

        [Display(Name = "Hizmet")]
        Hizmet = 3,
    }
}
