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
        public string PersonnelCode { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string Comment { get; set; }


        #endregion

        #region NAVIGATION PROPERTIES

        #endregion
    }
}
