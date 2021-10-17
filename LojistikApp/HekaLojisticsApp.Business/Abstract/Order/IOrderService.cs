using HekaLojisticsApp.Core.Tools.Result.Abstract;
using HekaLojisticsApp.Dto.Order;

namespace HekaLojisticsApp.Business.Abstract.Order
{
    public interface IOrderService
    {

        IDataResult<OrderDto> Get(int orderId);
        IDataResult<OrderDto> GetById(int orderId, bool includeCategory, bool includeComments, bool includeUser);
        IDataResult<ListOrderDto> GetAll();


        IResult Add(AddOrderDto addOrderDto, string createdByName, int userId);
        IResult Update(AddOrderDto addOrderDto, string modifiedByName);

        IResult Delete(int orderId, string modifiedByName);

    }
}
