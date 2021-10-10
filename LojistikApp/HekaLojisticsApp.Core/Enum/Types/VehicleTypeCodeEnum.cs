using System.ComponentModel.DataAnnotations;

namespace HekaLojisticsApp.Core.Enum.Types
{
    public enum VehicleTypeCodeEnum
    {
        [Display(Name = "Binek")]
        Binek = 0,

        [Display(Name = "Ticari")]
        Ticari = 1,

        [Display(Name = "Minibüs")]
        Minibus = 2,

        [Display(Name = "Forklift")]
        Forklift = 3,

        [Display(Name = "Traktör")]
        Traktor = 4,

        [Display(Name = "Kamyonet")]
        Kamyonet = 5,


    }
}
