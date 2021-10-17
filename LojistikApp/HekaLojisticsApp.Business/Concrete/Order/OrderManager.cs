using AutoMapper;
using HekaLojisticsApp.Business.Abstract.Order;
using HekaLojisticsApp.Business.Concrete.Base;
using HekaLojisticsApp.Core.AppMessages.Order;
using HekaLojisticsApp.Core.Enum.Status;
using HekaLojisticsApp.Core.Tools.Result.Abstract;
using HekaLojisticsApp.Core.Tools.Result.Concrete;
using HekaLojisticsApp.DataAccess.Concrete.UnitOfWork;
using HekaLojisticsApp.Dto.Order;

namespace HekaLojisticsApp.Business.Concrete.Order
{
    public class OrderManager : ManagerBase, IOrderService
    {

        #region FIELDS



        #endregion

        #region CTOR
        public OrderManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        #endregion

        #region METHODS

        public IResult Add(AddOrderDto addOrderDto, string createdByName, int userId)
        {
            throw new System.NotImplementedException();
        }

        public IResult Delete(int orderId, string modifiedByName)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<OrderDto> Get(int orderId)
        {
            throw new System.NotImplementedException();
        }

        public IDataResult<ListOrderDto> GetAll()
        {
            var orders = UnitOfWork.Order.GetAll(null);
            var ordersDto = Mapper.Map<ListOrderDto>(orders);


            if (orders.Count > -1)
            {
                return new DataResult<ListOrderDto>(ResultStatusEnum.Success, new ListOrderDto
                {
                    //Orders =IList<ordersDto>,
                    ResultStatus = ResultStatusEnum.Success
                });
            }
            return new DataResult<ListOrderDto>(ResultStatusEnum.Error, OrderResource.Order_NotFound, null);
        }

        public IDataResult<OrderDto> GetById(int orderId, bool includeCategory, bool includeComments, bool includeUser)
        {
            throw new System.NotImplementedException();
        }

        public IResult Update(AddOrderDto addOrderDto, string modifiedByName)
        {
            throw new System.NotImplementedException();
        }
        #endregion


    }
}
