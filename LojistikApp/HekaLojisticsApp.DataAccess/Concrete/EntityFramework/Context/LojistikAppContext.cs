using HekaLojisticsApp.Entities.Concrete.Order;
using Microsoft.EntityFrameworkCore;

namespace HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Context
{
    public class LojistikAppContext : DbContext
    {
        #region CTOR
        public LojistikAppContext(DbContextOptions<LojistikAppContext> options) : base(options)
        {

        }

        #endregion

        #region DBSET

        public DbSet<OrderEntity> Order { get; set; }

        #endregion

        #region MAPPING & SEED
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        #endregion


    }
}
