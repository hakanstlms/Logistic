using HekaLojisticsApp.DataAccess.Abstract.Order;
using System;

namespace HekaLojisticsApp.DataAccess.Concrete.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {

        IOrderRepository Order { get; }
        int Save();


    }
}
