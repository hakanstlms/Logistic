using System.ComponentModel.DataAnnotations;

namespace HekaLojisticsApp.Core.Enum.Status
{
    public enum OrderStatusCodeEnum
    {
        [Display(Name = "Teyit Bekliyor")]
        Grupaj = 0,

        [Display(Name = "Planlamada")]
        Planlamada = 1,

        [Display(Name = "Kesin Değil")]
        KesinDegil = 2,


        [Display(Name = "Sevk Edildi")]
        SevkEdildi = 3,

        [Display(Name = "İptal Oldu")]
        IptalEdildi = 4,


    }
}
