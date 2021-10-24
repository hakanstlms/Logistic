using System.ComponentModel.DataAnnotations;

namespace HekaLojisticsApp.Core.Enum.Types
{
    public enum AddressTypeEnum
    {

        [Display(Name = "Depo Adresi")]
        DepoAdres = 0,

        [Display(Name = "Firma Adresi")]
        FirmaAdres = 1,

        [Display(Name = "Sevkiyat Adresi")]
        SevkiyatAdres = 2,
 
        [Display(Name = "Fatura Adresi")]
        FaturaAdres = 3,
    }
}
