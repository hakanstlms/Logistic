using HekaLojisticsApp.Core.Enum.Types;
using HekaLojisticsApp.Entities.Abtract;
using HekaLojisticsApp.Entities.Base;

namespace HekaLojisticsApp.Entities.Concrete.Address
{
    public class AddressEntity : BaseEntity, IEntity
    {

        #region CTOR
        #endregion

        #region PROPERTIES
        public int AddressId { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }

        public string Email { get; set; }

        public string WebSite { get; set; }

        public AddressTypeEnum AdressType { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES
        #endregion


    }
}
