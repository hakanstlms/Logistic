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
    class VehicleCareTypeConfiguration : IEntityTypeConfiguration<VehicleCareTypeEntity>
    {

        public void Configure(EntityTypeBuilder<VehicleCareTypeEntity> builder)
        {
            #region FIELDS
            builder.HasKey(a => a.VehicleCareTypeId);
            builder.Property(a => a.VehicleCareTypeId).ValueGeneratedOnAdd();

            builder.Property(a => a.Code).HasMaxLength(12);
            builder.Property(a => a.Definition).HasMaxLength(80);
            builder.Property(a => a.DefaultPeriyodUnitCode).HasMaxLength(12);
            builder.Property(a => a.Compulsory);


            builder.Property(a => a.CreatedDate).IsRequired();
            builder.Property(a => a.UpdatedDate).IsRequired();
            builder.Property(a => a.CreatedUser).HasMaxLength(50);
            builder.Property(a => a.UpdatedUser).HasMaxLength(50);
            builder.Property(a => a.IsActive).IsRequired();
            builder.Property(a => a.Description).IsRequired();
            #endregion

            #region TABLE & SCHEMES

            builder.ToTable("CareType", "Vehicle");

            #endregion


            #region RELATIONS

            #endregion
        }

    }
}
