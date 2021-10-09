using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HekaLojisticsApp.Entities.Concrete.Order
{
    public class OrderEntity
    {
        #region CTOR

        #endregion

        #region PROPERTIES
        public int OrderId { get; set; }
        public string Code { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderTime { get; set; }
        //Yükleme Tarih
        public DateTime UploadDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public string UploadTypeCode { get; set; }
        //İşlem yön kod
        public string TransactionDrectionCode { get; set; }
        public string StatusCode { get; set; }
        //yükleme Noktası Kod
        public string UploadPointCode { get; set; }
        public int CompanyId { get; set; }
        //Gönderici Firma
        public int ShipperCompanyId { get; set; }
        public int BuyerCompanyId { get; set; }
        //Toplam Ağırlık
        public decimal TotalWeight { get; set; }
        //Toplam Hacim
        public decimal TotalVolume { get; set; }
        public string WeightUnitCode { get; set; }
        public string VolumeUnitCode { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalAmount { get; set; }
        public string CurrencyCode { get; set; }
        public char Closed { get; set; }
        public char Approval { get; set; }
        public char Cancel { get; set; }
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
        public int Commit { get; set; }
        #endregion

        #region NAVIGATION PROPERTIES

        #endregion
    }
}
