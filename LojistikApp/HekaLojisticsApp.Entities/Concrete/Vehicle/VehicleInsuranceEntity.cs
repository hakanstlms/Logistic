using HekaLojisticsApp.Core.Enum.Codes;
using HekaLojisticsApp.Entities.Abtract;
using HekaLojisticsApp.Entities.Base;
using System;

namespace HekaLojisticsApp.Entities.Concrete.Vehicle
{
    public class VehicleInsuranceEntity : BaseEntity, IEntity
    {
        // Araç Sigorta
        #region CTOR

        #endregion

        #region PROPERTIES
        public int VehicleInsuranceId { get; set; }
        public string VehicePlate { get; set; }
        public string InsuranceTypeCode { get; set; }
        public int OperationCompanyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int KmHour { get; set; }
        public string PersonnelId { get; set; }
        public decimal Amount { get; set; }
        public CurrencyCodeEnum CurrencyCode { get; set; }


        #endregion

        #region NAVIGATION PROPERTIES

        #endregion
    }
}
