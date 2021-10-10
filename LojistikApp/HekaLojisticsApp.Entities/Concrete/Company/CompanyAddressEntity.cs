using HekaLojisticsApp.Core.Enum.Types;
using HekaLojisticsApp.Entities.Abtract;
using HekaLojisticsApp.Entities.Base;

namespace HekaLojisticsApp.Entities.Concrete.Address
{
    public class CompanyAddressEntity : BaseEntity, IEntity
    {

        #region CTOR
        #endregion

        #region PROPERTIES
        public int CompanyAddressId { get; set; }
        public AddressTypeEnum AdressTypeId { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public bool MasterAddress { get; set; }
        public string Neighborhood { get; set; }
        public string Road { get; set; }
        public string Street { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Fax { get; set; }
        public string Description { get; set; }


        #endregion

        #region NAVIGATION PROPERTIES
        #endregion


    }
}
