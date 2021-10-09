using HekaLojisticsApp.Entities.Abtract;
using HekaLojisticsApp.Entities.Base;

namespace HekaLojisticsApp.Entities.Concrete.Company
{
    public class CompanyEntity : BaseEntity, IEntity
    {

        #region CTOR

        #endregion

        #region PROPERTIES
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }

        #endregion
    

        #region NAVIGATION PROPERTIES

        #endregion


    }
}
