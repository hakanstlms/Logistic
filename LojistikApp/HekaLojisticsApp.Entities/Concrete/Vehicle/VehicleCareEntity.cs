using HekaLojisticsApp.Core.Enum.Codes;
using HekaLojisticsApp.Entities.Abtract;
using HekaLojisticsApp.Entities.Base;
using System;

namespace HekaLojisticsApp.Entities.Concrete.Vehicle
{
    public class VehicleCareEntity:BaseEntity,IEntity
    {
        //Araç Bakım
        #region CTOR

        #endregion

        #region PROPERTIES
        public int VehicleCareId { get; set; }
        public string VehiclePlate { get; set; }
        public string VehiceCareTypeId { get; set; }
        public int OperationCompanyId { get; set; }
        public DateTime CareDate { get; set; }
        public int KmHour { get; set; }
        public string PersonnelId { get; set; }
        public decimal Amount { get; set; }
        public CurrencyCodeEnum CurrencyCode { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES

        #endregion
    }
}
