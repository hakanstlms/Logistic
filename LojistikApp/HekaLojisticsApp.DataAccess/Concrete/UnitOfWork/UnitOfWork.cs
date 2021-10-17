
using HekaLojisticsApp.DataAccess.Abstract.Order;
using HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Context;
using HekaLojisticsApp.DataAccess.Concrete.EntityFramework.Repositories.Order;

namespace HekaLojisticsApp.DataAccess.Concrete.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        #region FIELDS
        private readonly LojistikAppContext _context;

        private EfOrderRepository _orderRepository;
        public IOrderRepository Order => _orderRepository ?? new EfOrderRepository(_context);
        #endregion

        #region CTOR
        public UnitOfWork(LojistikAppContext context)
        {
            _context = context;
        }
        #endregion

        #region METHODS
        public void Dispose()
        {
            _context.Dispose();
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
        #endregion

    }
}
