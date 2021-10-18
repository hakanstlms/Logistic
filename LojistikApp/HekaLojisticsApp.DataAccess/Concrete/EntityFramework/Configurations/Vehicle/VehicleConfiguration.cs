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
    class VehicleConfiguration : IEntityTypeConfiguration<VehicleEntity>
    {
        public void Configure(EntityTypeBuilder<VehicleEntity> builder)
        {
            #region FIELDS
            builder.HasKey(a => a.VehicleId);
            builder.Property(a => a.VehicleId).ValueGeneratedOnAdd();

            builder.Property(a => a.Plate).HasMaxLength(20);
            builder.Property(a => a.Mark).HasMaxLength(80);
            builder.Property(a => a.Model).HasMaxLength(80);
            builder.Property(a => a.ChassisNumber).HasMaxLength(40);
            builder.Property(a => a.VehicleAllocationCode).HasMaxLength(12);
            builder.Property(a => a.VehicleTypeCode).HasMaxLength(12);
            builder.Property(a => a.OwnerCompanyId);
            builder.Property(a => a.ContractStartDate);
            builder.Property(a => a.ContractEndDate);
            builder.Property(a => a.CurrencyCode).HasMaxLength(10);
            builder.Property(a => a.KmHour);
            builder.Property(a => a.Amount);
            builder.Property(a => a.Length);
            builder.Property(a => a.Width);
            builder.Property(a => a.Height);
            builder.Property(a => a.TrailerHeadWeight);
            builder.Property(a => a.LoadCapacity);
            builder.Property(a => a.UnitId);
            builder.Property(a => a.TrailerTypeCode).HasMaxLength(12);
            builder.Property(a => a.PersonelId);
            builder.Property(a => a.StatusCode).HasMaxLength(12);
            builder.Property(a => a.CarePeriyot);
            builder.Property(a => a.ProportionalLimit);
            builder.Property(a => a.CareNotification);
            builder.Property(a => a.TireNotification);
            builder.Property(a => a.Approval);
            builder.Property(a => a.Invalidation);
            builder.Property(a => a.KmHourControl);


            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.UpdatedDate).IsRequired();
            builder.Property(a => a.CreatedUser).HasMaxLength(50);
            builder.Property(a => a.UpdatedUser).HasMaxLength(50);
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.Description).IsRequired();
            #endregion

            #region TABLE & SCHEMES
            builder.ToTable( "Main", "Vehicle");

            #endregion


            #region RELATIONS

            #endregion        }
        }
    }
}