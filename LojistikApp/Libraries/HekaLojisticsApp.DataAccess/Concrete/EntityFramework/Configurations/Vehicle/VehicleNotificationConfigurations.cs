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
    class VehicleNotificationConfigurations : IEntityTypeConfiguration < VehicleNotificationEntity>     
    {

        public void Configure(EntityTypeBuilder<VehicleNotificationEntity> builder)
        {
            #region FIELDS
            builder.HasKey(a => a.VehicleNotificationId);
            builder.Property(a => a.VehicleNotificationId).ValueGeneratedOnAdd();

            builder.Property(a => a.VehicePlate).HasMaxLength(20);
            builder.Property(a => a.CareStep);
            builder.Property(a => a.MailNotification);
            builder.Property(a => a.SmsNotification);
            builder.Property(a => a.ExtraNotification);


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
