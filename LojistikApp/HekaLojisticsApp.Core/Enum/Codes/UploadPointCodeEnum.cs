using System.ComponentModel.DataAnnotations;

namespace HekaLojisticsApp.Core.Enum.Codes
{
    public enum UploadPointCodeEnum
    {
        [Display(Name = "Müşteriden")]
        Musteriden = 0,

        [Display(Name = "Depodan")]
        Depodan = 1,



    }
}
