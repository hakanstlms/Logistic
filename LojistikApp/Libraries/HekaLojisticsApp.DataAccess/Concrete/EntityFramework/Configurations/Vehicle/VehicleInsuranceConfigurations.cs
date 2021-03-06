using HekaLojisticsApp.Entities.Concrete.Vehicle;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Configurations.Vehicle
{
    class VehicleInsuranceConfigurations : IEntityTypeConfiguration <VehicleInsuranceEntity>  
    {

        public void Configure(EntityTypeBuilder<VehicleInsuranceEntity> builder)
        {
            #region FIELDS
            builder.HasKey(a => a.VehicleInsuranceId);
            builder.Property(a => a.VehicleInsuranceId).ValueGeneratedOnAdd();

            builder.Property(a => a.VehicePlate).HasMaxLength(20);
            builder.Property(a => a.InsuranceTypeCode).HasMaxLength(12);
            builder.Property(a => a.OperationCompanyId);
            builder.Property(a => a.StartDate);
            builder.Property(a => a.EndDate);
            builder.Property(a => a.KmHour);
            builder.Property(a => a.PersonnelId);
            builder.Property(a => a.Amount);
            builder.Property(a => a.CurrencyCode).HasMaxLength(12);


            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.UpdatedDate).IsRequired();
            builder.Property(a => a.CreatedUser).HasMaxLength(50);
            builder.Property(a => a.UpdatedUser).HasMaxLength(50);
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.Description).IsRequired();
            #endregion

            #region TABLE & SCHEMES

            // builder.ToTable("Company","Company");

            #endregion


            #region RELATIONS

            #endregion
        }

    }
}
