using HekaLojisticsApp.Core.Settings;
using HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Configurations.Order;
using HekaLojisticsApp.Entities.Concrete.Order;
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

        #endregion

        #region MAPPING & SEED
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new OrderConfiguration());

         
        }

        #endregion


    }
}
