using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HekaLojisticsApp.Core.Enum.Codes
{
    public enum PeriyodUnitCodeEnum
    {
        [Display(Name = "1 Gün")]
        BirGun = 0,
        [Display(Name = "1 Ay")]
        BirAy = 1,
        [Display(Name = "1 Yıl")]
        BirYıl = 2,
		/*
1 Ay
	1	GUN	1 Gün
	1	YIL	1 Yıl
	2	AY	2 Ay
	2	YIL	2 Yıl
	3	AY	3 Ay
	3	YIL	3 Yıl
	4	AY	4 Ay
	4	YIL	4 Yıl
	5	AY	5 Ay
	5	YIL	5 Yıl
	6	AY	6 Ay
	7	AY	7 Ay
	7	GUN	7 Gün
	8	AY	8 Ay
	9	AY	9 Ay
	10	AY	10 Ay
	10	GUN	10 Gün
	11	AY	11 Ay
	12	AY	12 Ay
	12	GUN	12 Gün
	15	GUN	15 Gün
	24	AY	24 Ay
	30	GUN	30 Gün
	36	AY	36 Ay
	45	GUN	45 Gün
	90	GUN	90 Gün
         */


	}
}
