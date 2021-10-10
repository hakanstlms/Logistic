using HekaLojisticsApp.Core.Enum.Codes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HekaLojisticsApp.Entities.Concrete.Vehicle
{
    public class VehicleInsuranceEntity
    {
        // Araç Sigorta
        #region CTOR

        #endregion

        #region PROPERTIES
        public int VehicleInsuranceId { get; set; }
        public string VehicePlate { get; set; }
        public string InsuranceTypeCode { get; set; }
        public  int OperationCompanyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int KmHour { get; set; }
        public string PersonnelId { get; set; }
        public decimal Amount { get; set; }
        public CurrencyCodeEnum CurrencyCode { get; set; }
        public string Description { get; set; }


        #endregion

        #region NAVIGATION PROPERTIES

        #endregion
    }
}
