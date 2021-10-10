using HekaLojisticsApp.Core.Enum.Codes;
using HekaLojisticsApp.Core.Enum.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HekaLojisticsApp.Entities.Concrete.Vehicle
{
    public class VehiceTireEntity
    {
        //ARAÇ lASTİK
        #region CTOR

        #endregion

        #region PROPERTIES

        public int VehiceTireId { get; set; }
        public string VehiclePlate { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public VehiceTireTypeEnum VehiceTireTypeCode { get; set; }
        public string SeriNo { get; set; }
        //Yon tip kod
        public DirectionTypeCodeEnum DirectionTypeCode { get; set; }
        //Ebat bilgi
        public string DimensionsInfo { get; set; }
        //Montaj tarih
        public DateTime MontageDate { get; set; }
        public int OperationCompanyId { get; set; }
        public string PersonnelId  { get; set; }
        public int KmHour { get; set; }
        public int KmHourLimit { get; set; }
        public char KmHourControl { get; set; }
        //iptal
        public char Invalidation { get; set; }
        public CurrencyCodeEnum CurrencyCode { get; set; }
        //Toplam
        public decimal Amount { get; set; }
        public string Description { get; set; }
        #endregion

        #region NAVIGATION PROPERTIES

        #endregion

    }
}
