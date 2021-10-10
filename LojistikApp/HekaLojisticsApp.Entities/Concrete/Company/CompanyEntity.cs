using HekaLojisticsApp.Core.Enum.Types;
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
        public string Code { get; set; }
        public string Name { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        //Önceki Ünvan
        public string PreviousTitle { get; set; }
        public CompanyTypeEnum CompanyTypeId { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        //Ticari sicil No
        public string CommercialRegistrationNo { get; set; }
        //E fatura kapsamında
        public bool EInvoiceWithin { get; set; }
        public string CustomerRepresentative { get; set; }
        public string EInvoiceTitle { get; set; }
        //Şahıs Şirketi
        public bool SoleProprietorship { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public int DistrictId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public bool Problem { get; set; }
        public bool Cancel { get; set; }
        public string WebSite { get; set; }
        public string Description { get; set; }



        #endregion


        #region NAVIGATION PROPERTIES

        public List<AddressEntity> Address { get; set; }
        #endregion


    }
}
