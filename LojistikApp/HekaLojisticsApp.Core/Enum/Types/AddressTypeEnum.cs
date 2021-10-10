using System.ComponentModel.DataAnnotations;

namespace HekaLojisticsApp.Core.Enum.Types
{
    public enum AddressTypeEnum
    {

        [Display(Name = "Depo Adresi")]
        DepoAdresi = 0,

        [Display(Name = "Firma Adresi")]
        FirmaAdresi = 1,

    }
}
