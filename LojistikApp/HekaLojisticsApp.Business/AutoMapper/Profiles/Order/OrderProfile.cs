using AutoMapper;
using HekaLojisticsApp.Dto.Order;
using HekaLojisticsApp.Entities.Concrete.Order;
using System.Collections.Generic;

namespace HekaLojisticsApp.Business.AutoMapper.Profiles.Order
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderEntity, OrderDto>();

            CreateMap<List<OrderEntity>, List<OrderDto>>();


            CreateMap<OrderDto, OrderEntity>();

            CreateMap<AddOrderDto, OrderEntity>();

            CreateMap<UpdateOrderDto, OrderEntity>();

            CreateMap<ListOrderDto, OrderEntity>();


        }



    }
}
