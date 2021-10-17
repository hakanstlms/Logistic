using HekaLojisticsApp.Entities.Concrete.Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Configurations.Order
{
    public class OrderConfiguration:IEntityTypeConfiguration<OrderEntity>
    {

        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            #region FIELDS
            builder.HasKey(a => a.OrderId);
            builder.Property(a => a.OrderId).ValueGeneratedOnAdd();

            builder.Property(a => a.OrderCode).HasMaxLength(20);
            builder.Property(a => a.OrderDate);
            builder.Property(a => a.OrderTime);
            builder.Property(a => a.UploadDate);
            builder.Property(a => a.DeadlineDate);
            builder.Property(a => a.UploadTypeCode).HasMaxLength(12);
            builder.Property(a => a.TransactionDirectionCode).HasMaxLength(12);
            builder.Property(a => a.StatusCode).HasMaxLength(12);
            builder.Property(a => a.UploadPointCode).HasMaxLength(12);
            builder.Property(a => a.CompanyId);
            builder.Property(a => a.ShipperCompanyId);
            builder.Property(a => a.BuyerCompanyId);
            builder.Property(a => a.TotalWeight);
            builder.Property(a => a.TotalVolume);
            builder.Property(a => a.WeightUnitCode).HasMaxLength(12);
            builder.Property(a => a.VolumeUnitCode).HasMaxLength(12);
            builder.Property(a => a.Amount);
            builder.Property(a => a.TotalAmount);
            builder.Property(a => a.CurrencyCode).HasMaxLength(12);
            builder.Property(a => a.Closed);
            builder.Property(a => a.Approval);
            builder.Property(a => a.Cancel);
            builder.Property(a => a.ApprovalDate);
            builder.Property(a => a.InvoiceStatusCode).HasMaxLength(12);
            builder.Property(a => a.ExitCustomsCode).HasMaxLength(12);
            builder.Property(a => a.EntryCustomsCode).HasMaxLength(12);
            builder.Property(a => a.CustomerRepresentative);
            builder.Property(a => a.CustomerTitle1);
            builder.Property(a => a.CustomerTitle2);
            builder.Property(a => a.CustomerAddress1);
            builder.Property(a => a.CustomerAddress2);
            builder.Property(a => a.CustomerDistrictId);
            builder.Property(a => a.CustomerCityId);
            builder.Property(a => a.CustomerCountryId);
            builder.Property(a => a.CustomerTaxOffice);
            builder.Property(a => a.CustomerTaxNumber);
            builder.Property(a => a.CustomerNumber);
            builder.Property(a => a.CustomerFax);
            builder.Property(a => a.BuyerRepresentative);
            builder.Property(a => a.BuyerCustomerTitle1);
            builder.Property(a => a.BuyerCustomerTitle2);
            builder.Property(a => a.BuyerCustomerAddress1);
            builder.Property(a => a.BuyerCustomerAddress2);
            builder.Property(a => a.BuyerCustomerDistrictId);
            builder.Property(a => a.BuyerCustomerCityId);
            builder.Property(a => a.BuyerCustomerCountryId);
            builder.Property(a => a.BuyerCustomerTaxOffice);
            builder.Property(a => a.BuyerCustomerTaxNumber);
            builder.Property(a => a.BuyerCustomerNumber);
            builder.Property(a => a.BuyerCustomerFax);
            builder.Property(a => a.Rate);
            builder.Property(a => a.RateDate);


            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.UpdatedDate).IsRequired();
            builder.Property(a => a.CreatedUser).HasMaxLength(50);
            builder.Property(a => a.UpdatedUser).HasMaxLength(50);
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.Description).IsRequired();
            #endregion

            #region TABLE & SCHEMES

            builder.ToTable("Order", "Order");

            #endregion


            #region RELATIONS

            #endregion

        }

    }
}
