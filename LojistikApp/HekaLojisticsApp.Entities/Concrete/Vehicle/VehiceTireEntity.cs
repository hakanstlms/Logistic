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
        public string TypeCode { get; set; }
        public string SeriNo { get; set; }
        //Yon tip kod
        public string WayTypeCode { get; set; }
        //ebat bilgi
        public string DimensionsInfo { get; set; }
        //montaj tarih
        public DateTime MontageDate { get; set; }
        public int OperationCompanyId { get; set; }
        public string PersonnelCode  { get; set; }
        public int KmHour { get; set; }
        public int KmHourLimit { get; set; }
        public char KmHourControl { get; set; }
        //iptal
        public char Invalidation { get; set; }
        public string CurrencyCode { get; set; }
        //Toplam
        public decimal Amount { get; set; }
        public string Comment { get; set; }
        #endregion

        #region NAVIGATION PROPERTIES

        #endregion

    }
}
