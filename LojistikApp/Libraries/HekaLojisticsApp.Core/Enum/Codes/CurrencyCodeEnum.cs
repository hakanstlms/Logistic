using System.ComponentModel.DataAnnotations;

namespace HekaLojisticsApp.Core.Enum.Codes
{
    public enum CurrencyCodeEnum
    {

        [Display(Name = "Türk Lirası")]
        TL = 0,

        [Display(Name = "Dolar")]
        Dolar = 1,

        [Display(Name = "Euro")]
        Euro = 2,

      

    }
}
