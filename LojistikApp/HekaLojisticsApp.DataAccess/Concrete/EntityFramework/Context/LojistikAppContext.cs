using HekaLojisticsApp.Core.Settings;
using HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Configurations.Order;
using HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Configurations.Vehicle;
using HekaLojisticsApp.Entities.Concrete.Order;
using HekaLojisticsApp.Entities.Concrete.Vehicle;
using Microsoft.EntityFrameworkCore;


namespace HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Context
{
    public class LojistikAppContext : DbContext
    {
        #region CTOR
        public LojistikAppContext()
        {

        }

        #endregion

        #region CONFIGURE
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppSetting.ConnectionStrings);

        }
        #endregion

        #region DBSET

        public DbSet<OrderEntity> Order { get; set; }
        public DbSet<VehicleTireEntity> VehicleTire { get; set; }
        public DbSet<VehicleCareEntity> VehicleCare { get; set; }
        public DbSet<VehicleCareTypeEntity> VehicleCareType { get; set; }
        public DbSet<VehicleEntity> Vehicle { get; set; }
        public DbSet<VehicleInsuranceEntity> VehicleInsurance { get; set; }
        public DbSet<VehicleInsuranceTypeEntity> VehicleInsuranceType { get; set; }
        public DbSet<VehicleNotificationEntity> VehicleNotification { get; set; }


        #endregion

        #region MAPPING & SEED
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleTireConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleCareConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleCareTypeConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleInsuranceConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleInsuranceTypeConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleNotificationConfiguration());


        }

        #endregion


    }
}
