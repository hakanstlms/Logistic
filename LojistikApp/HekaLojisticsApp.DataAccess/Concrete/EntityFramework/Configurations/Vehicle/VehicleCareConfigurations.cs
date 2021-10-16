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
    class VehicleCareConfigurations : IEntityTypeConfiguration<VehicleCareEntity>
    {
        public void Configure(EntityTypeBuilder<VehicleCareEntity> builder)
        {
            #region FIELDS
            builder.HasKey(a => a.VehiceCareTypeId );
            builder.Property(a => a.VehiceCareTypeId).ValueGeneratedOnAdd();

            builder.Property(a => a.VehiclePlate).HasMaxLength(50);
            builder.Property(a => a.VehiceCareTypeId).HasMaxLength(50);
            builder.Property(a => a.OperationCompanyId).HasMaxLength(50);
            builder.Property(a => a.CareDate).HasMaxLength(50);
            builder.Property(a => a.KmHour).HasMaxLength(50);
            builder.Property(a => a.PersonnelId).HasMaxLength(50);
            builder.Property(a => a.Amount).HasMaxLength(50);
            builder.Property(a => a.CurrencyCode).HasMaxLength(50);


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
