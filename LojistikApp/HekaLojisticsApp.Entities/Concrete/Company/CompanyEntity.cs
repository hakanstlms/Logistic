using HekaLojisticsApp.Entities.Abtract;
using HekaLojisticsApp.Entities.Base;
using HekaLojisticsApp.Entities.Concrete.Address;
using System.Collections.Generic;

namespace HekaLojisticsApp.Entities.Concrete.Company
{
    public class CompanyEntity : BaseEntity, IEntity
    {

        #region CTOR

        #endregion

        #region PROPERTIES
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string CustomerRepresentative { get; set; }
  
        

        #endregion


        #region NAVIGATION PROPERTIES

        public List<AddressEntity> Address { get; set; }
        #endregion


    }
}
