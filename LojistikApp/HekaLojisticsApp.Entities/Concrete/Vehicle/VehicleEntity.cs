using HekaLojisticsApp.Entities.Abtract;
using HekaLojisticsApp.Entities.Base;
using Microsoft.OData.Edm;

namespace HekaLojisticsApp.Entities.Concrete.Vehicle
{
    public class VehicleEntity : BaseEntity,IEntity
    {

        #region CTOR

        #endregion

        #region PROPERTIES

        public int VehicleId { get; set; }
        public string Plate { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string ChassisNumber { get; set; }
        public string VehicleAllocationCode { get; set; }
        public string VehicleTypeCode { get; set; }
        public string OwnerCompanyId { get; set; }
        public Date ContractStartDate { get; set; }
        public Date ContractEndDate { get; set; }
        public string CurrencyCode { get; set; }
        public int KmHour { get; set; }
        public decimal Amount { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal TrailerHeadWeight { get; set; }
        public decimal LoadCapacity { get; set; }
        public string UnitKod { get; set; }
        public string TrailerTypeCode { get; set; }
        public string PersonelCode { get; set; }
        public string StatusCode { get; set; }
        public int CarePeriyot { get; set; }
        // Oransal sınır
        public int ProportionalLimit { get; set; }
        // Bakım bildirim
        public char CareNotification { get; set; }
        //Lastik bildirim
        public char TireNotification { get; set; }
        public char Approval { get; set; }
        public char İnvalidation { get; set; }
        public char KmHourControl { get; set; }
        public string Comment { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES




        #endregion



    }
}
