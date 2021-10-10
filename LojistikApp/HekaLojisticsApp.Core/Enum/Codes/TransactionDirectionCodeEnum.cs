using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HekaLojisticsApp.Core.Enum.Codes
{
    public enum TransactionDirectionCodeEnum
    {
        [Display(Name = "Türkiyeden Yurt Dışına Mal-Hizmet Çıkışı")]
        TYMC = 0,

        [Display(Name = "Türkiye ye Yurt Dışına Mal-Hizmet Girişi")]
        TYMG = 1,

        [Display(Name = "Türkiye İçi Mal-Hizmet Alım/Satımı")]
        TIMS = 2,

        [Display(Name = "Türkiye içi Transfer G.D. Giriş")]
        TITG = 3,

        [Display(Name = "Türkiyeden Yurt Dışı Transfer G.D. Çıkış")]
        TYTC = 4,
    }
}
