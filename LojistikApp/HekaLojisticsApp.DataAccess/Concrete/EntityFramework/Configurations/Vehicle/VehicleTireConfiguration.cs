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
    class VehicleTireConfiguration : IEntityTypeConfiguration<VehicleTireEntity>
    {
        public void Configure(EntityTypeBuilder<VehicleTireEntity> builder)
        {
            #region FIELDS
            builder.HasKey(a => a.VehiceTireId);
            builder.Property(a => a.VehiceTireId).ValueGeneratedOnAdd();

            builder.Property(a => a.VehiclePlate).HasMaxLength(20);
            builder.Property(a => a.Mark).HasMaxLength(80);
            builder.Property(a => a.Model).HasMaxLength(80);
            builder.Property(a => a.VehiceTireTypeCode).HasMaxLength(12);
            builder.Property(a => a.SeriNo).HasMaxLength(40);
            builder.Property(a => a.DirectionTypeCode).HasMaxLength(12);
            builder.Property(a => a.DimensionsInfo).HasMaxLength(80);
            builder.Property(a => a.MontageDate);
            builder.Property(a => a.OperationCompanyId);
            builder.Property(a => a.PersonnelId);
            builder.Property(a => a.KmHour);
            builder.Property(a => a.KmHourLimit);
            builder.Property(a => a.KmHourControl);
            builder.Property(a => a.Invalidation);
            builder.Property(a => a.CurrencyCode).HasMaxLength(10);
            builder.Property(a => a.Amount);

            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.UpdatedDate).IsRequired();
            builder.Property(a => a.CreatedUser).HasMaxLength(50);
            builder.Property(a => a.UpdatedUser).HasMaxLength(50);
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.Description).IsRequired();
            #endregion
            #region TABLE & SCHEMES
            builder.ToTable("Tire", "Vehicle");


            #endregion


            #region RELATIONS

            #endregion        }
        }
    }
}
