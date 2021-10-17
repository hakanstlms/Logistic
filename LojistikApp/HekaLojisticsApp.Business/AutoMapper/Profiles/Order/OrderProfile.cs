using AutoMapper;
using HekaLojisticsApp.Dto.Order;
using HekaLojisticsApp.Entities.Concrete.Order;

namespace HekaLojisticsApp.Business.AutoMapper.Profiles.Order
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderEntity, OrderDto>();
            CreateMap<OrderDto, OrderEntity>();

            CreateMap<AddOrderDto, OrderEntity>();

            CreateMap<UpdateOrderDto, OrderEntity>();

            CreateMap<ListOrderDto, OrderEntity>();


        }



    }
}
