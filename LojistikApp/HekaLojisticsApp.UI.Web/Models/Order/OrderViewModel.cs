using HekaLojisticsApp.Dto.Order;

namespace HekaLojisticsApp.UI.Web.Models.Order
{
    public class OrderViewModel
    {

        public AddOrderDto AddOrderDto { get; set; }

        public ListOrderDto Orders { get; set; }

        public UpdateOrderDto UpdateOrderDto { get; set; }


    }
}
