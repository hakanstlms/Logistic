using HekaLojisticsApp.Dto.Order;
using HekaLojisticsApp.Core.Enum.Codes;

namespace HekaLojisticsApp.UI.Web.Models.Order
{
    public class OrderViewModel
    {
        #region DTOS
        public AddOrderDto AddOrderDto { get; set; }

        public ListOrderDto Orders { get; set; }

        public UpdateOrderDto UpdateOrderDto { get; set; }
        #endregion

        #region ENUMS

        public CurrencyCodeEnum CurrencyCode { get;  }
        #endregion



    }
}
