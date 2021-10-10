using HekaLojisticsApp.Core.Enum.Codes;
using HekaLojisticsApp.Core.Enum.Status;
using HekaLojisticsApp.Entities.Abtract;
using HekaLojisticsApp.Entities.Base;
using System;

namespace HekaLojisticsApp.Entities.Concrete.Order
{
    public class OrderEntity:BaseEntity,IEntity
    {
        #region CTOR
        public OrderEntity()
        {
            OrderDate = DateTime.Now.ToShortDateString();
            OrderTime = DateTime.Now.ToShortTimeString();
            

        }
        #endregion

        #region PROPERTIES
        public int OrderId { get; set; }
        public string OrderCode { get; set; }
        public string OrderDate { get; set; }
        public string OrderTime { get; set; }
        //Yükleme Tarih
        public DateTime UploadDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public UploadTypeCodeEnum UploadTypeCode { get; set; }
        //İşlem yön kod
        public string TransactionDirectionCode { get; set; }
        public OrderStatusCodeEnum StatusCode { get; set; }
        //yükleme Noktası Kod
        public UploadPointCodeEnum UploadPointCode { get; set; }
        public int CompanyId { get; set; }
        //Gönderici Firma
        public int ShipperCompanyId { get; set; }
        public int BuyerCompanyId { get; set; }
        //Toplam Ağırlık
        public decimal TotalWeight { get; set; }
        //Toplam Hacim
        public decimal TotalVolume { get; set; }
        public UnitCodeEnum WeightUnitCode { get; set; }
        public UnitCodeEnum VolumeUnitCode { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalAmount { get; set; }
        public CurrencyCodeEnum CurrencyCode { get; set; }
        public bool Closed { get; set; }
        public bool Approval { get; set; }
        public bool Cancel { get; set; }
        public DateTime ApprovalDate { get; set; }
        //Fatura Durum Kod
        public string InvoiceStatusCode { get; set; }
        //Çıkış Gümrük Kod
        public string ExitCustomsCode { get; set; }
        public string EntryCustomsCode { get; set; }
        //Müşteri Temsilcisi
        public string CustomerRepresentative { get; set; }
        public string CustomerTitle1 { get; set; }
        public string CustomerTitle2 { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerDistrictId { get; set; }
        public string CustomerCityId { get; set; }
        public string CustomerCountryId { get; set; }
        public string CustomerTaxOffice { get; set; }
        public string CustomerTaxNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerFax { get; set; }
        public string BuyerRepresentative { get; set; }
        public string BuyerCustomerTitle1 { get; set; }
        public string BuyerCustomerTitle2 { get; set; }
        public string BuyerCustomerAddress1 { get; set; }
        public string BuyerCustomerAddress2 { get; set; }
        public string BuyerCustomerDistrictId { get; set; }
        public string BuyerCustomerCityId { get; set; }
        public string BuyerCustomerCountryId { get; set; }
        public int BuyerCustomerTaxOffice { get; set; }
        public int BuyerCustomerTaxNumber { get; set; }
        public int BuyerCustomerNumber { get; set; }
        public int BuyerCustomerFax { get; set; }
        public int CurrencyKod { get; set; }
        //Kur
        public int Rate { get; set; }
        public DateTime RateDate { get; set; }
      
        #endregion

        #region NAVIGATION PROPERTIES

        #endregion
    }
}
