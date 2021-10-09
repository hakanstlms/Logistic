using System;
using HekaLojisticsApp.Entities.Concrete.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Configurations.Company
{
    public class CompanyConfigurations : IEntityTypeConfiguration<CompanyEntity>
    {
        public void Configure(EntityTypeBuilder<CompanyEntity> builder)
        {

            #region FIELDS
            builder.HasKey(a => a.CompanyId);
            builder.Property(a => a.CompanyId).ValueGeneratedOnAdd();



            builder.Property(a => a.CreatedUser).HasMaxLength(50);
            builder.Property(a => a.UpdatedUser).HasMaxLength(50);
            builder.Property(a => a.IsActive).IsRequired();
            #endregion

            #region TABLE & SCHEMES

           // builder.ToTable("Company","Company");

            #endregion


            #region RELATIONS

            #endregion



        }
    }
}
