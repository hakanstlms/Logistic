using System.ComponentModel.DataAnnotations;

namespace HekaLojisticsApp.Core.Enum.Codes
{
    public enum UnitCodeEnum
    {
        [Display(Name = "Metre")]
        Metre = 0,

        [Display(Name = "Kg")]
        Kg = 1,

        [Display(Name = "Ton")]
        Ton = 2,

        [Display(Name = "MetreKüp")]
        MetreKup = 3,

    }
}
