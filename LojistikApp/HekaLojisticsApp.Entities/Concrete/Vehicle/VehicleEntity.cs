using HekaLojisticsApp.Core.Enum.Codes;
using HekaLojisticsApp.Core.Enum.Types;
using HekaLojisticsApp.Entities.Abtract;
using HekaLojisticsApp.Entities.Base;
using System;

namespace HekaLojisticsApp.Entities.Concrete.Vehicle
{
    public class VehicleEntity : BaseEntity, IEntity
    {

        #region CTOR

        #endregion

        #region PROPERTIES

        public int VehicleId { get; set; }
        public string Plate { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string ChassisNumber { get; set; }
        public VehicleAllocationCodeEnum VehicleAllocationCode { get; set; }
        public VehicleTypeCodeEnum VehicleTypeCode { get; set; }
        public string OwnerCompanyId { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        public string CurrencyCode { get; set; }
        public int KmHour { get; set; }
        public decimal Amount { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal TrailerHeadWeight { get; set; }
        public decimal LoadCapacity { get; set; }
        public string UnitId { get; set; }
        public TrailerTypeCodeEnum TrailerTypeCode { get; set; }
        public int PersonelId { get; set; }
        public StatusCodeEnum StatusCode { get; set; }
        public int CarePeriyot { get; set; }
        // Oransal sınır
        public int ProportionalLimit { get; set; }
        // Bakım bildirim
        public char CareNotification { get; set; }
        //Lastik bildirim
        public char TireNotification { get; set; }
        public char Approval { get; set; }
        public char Invalidation { get; set; }
        public char KmHourControl { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES




        #endregion



    }
}
