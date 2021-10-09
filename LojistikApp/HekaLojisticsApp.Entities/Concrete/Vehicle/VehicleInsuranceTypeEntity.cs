using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HekaLojisticsApp.Entities.Concrete.Vehicle
{
    public class VehicleInsuranceTypeEntity
    {
        //araç sigorta Tip
        #region CTOR

        #endregion

        #region PROPERTIES
        public int VehicleInsuranceTypeId { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public string DefaultPeriyodUnitCode { get; set; }
        public string DefaultPeriyodCode { get; set; }
        public char Compulsory { get; set; }
        #endregion

        #region NAVIGATION PROPERTIES

        #endregion

    }
}
