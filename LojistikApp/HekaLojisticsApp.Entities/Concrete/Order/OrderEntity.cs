using HekaLojisticsApp.Core.Enum.Codes;
using HekaLojisticsApp.Core.Enum.Status;
using HekaLojisticsApp.Entities.Abtract;
using HekaLojisticsApp.Entities.Base;
using HekaLojisticsApp.Entities.Concrete.Company;
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
        public ExitCustomsCodeEnum ExitCustomsCode { get; set; }
        public ExitCustomsCodeEnum EntryCustomsCode { get; set; }
       
        //Kur
        public int Rate { get; set; }
        public DateTime RateDate { get; set; }

        #endregion

        #region NAVIGATION PROPERTIES
       // public CompanyEntity CompanyEntity { get; set; }

        #endregion
    }
}
