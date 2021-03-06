using HekaLojisticsApp.Core.Enum.Codes;
using HekaLojisticsApp.Entities.Abtract;
using HekaLojisticsApp.Entities.Base;

namespace HekaLojisticsApp.Entities.Concrete.Vehicle
{
    public class VehicleInsuranceTypeEntity : BaseEntity, IEntity
    {
        //araç sigorta Tip
        #region CTOR

        #endregion

        #region PROPERTIES
        public int VehicleInsuranceTypeId { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public PeriyodUnitCodeEnum DefaultPeriyodUnitCode { get; set; }
        //public string DefaultPeriyodCode { get; set; }
        //Zorunlu
        public char Compulsory { get; set; }
        #endregion

        #region NAVIGATION PROPERTIES

        #endregion

    }
}
