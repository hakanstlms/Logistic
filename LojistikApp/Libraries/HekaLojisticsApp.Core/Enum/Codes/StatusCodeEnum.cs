using System.ComponentModel.DataAnnotations;

namespace HekaLojisticsApp.Core.Enum.Codes
{
    public enum StatusCodeEnum
    {
        [Display(Name = "Pasif")]
        Pasif = 0,

        [Display(Name = "Aktif")]
        Aktif = 1,

    }
}
