using HekaLojisticsApp.Core.Enum.Codes;
using System;

namespace HekaLojisticsApp.Entities.Concrete.Vehicle
{
    public class VehicleCareEntity
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
        public string PersonnelCode { get; set; }
        public decimal Amount { get; set; }
        public CurrencyCodeEnum CurrencyCode { get; set; }
        public string Description { get; set; }


        #endregion

        #region NAVIGATION PROPERTIES

        #endregion
    }
}
