using HekaLojisticsApp.Dto.Base;
using System.Collections.Generic;

namespace HekaLojisticsApp.Dto.Order
{
    public class ListOrderDto: ListBaseDto
    {

        public IList<OrderDto> Orders { get; set; }

    }
}
