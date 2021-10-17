using HekaLojisticsApp.DataAccess.Abstract.Order;
using HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Repositories.Base;
using HekaLojisticsApp.Entities.Concrete.Order;
using Microsoft.EntityFrameworkCore;

namespace HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Repositories.Order
{
    public class EfOrderRepository : EntityRepositoryBase<OrderEntity>, IOrderRepository
    {

        public EfOrderRepository(DbContext context) : base(context)
        {

        }

    }
}
