using HekaLojisticsApp.Business.Abstract.Order;
using HekaLojisticsApp.UI.Web.Areas.Secure.Base;
using HekaLojisticsApp.UI.Web.Filters;
using HekaLojisticsApp.UI.Web.Models.Order;
using Microsoft.AspNetCore.Mvc;

namespace HekaLojisticsApp.UI.Web.Areas.Secure.Controllers
{
    public class OrderController : BaseController
    {

        #region FIELDS

        private readonly IOrderService _orderService;
        #endregion

        #region CTOR
        public OrderController(IOrderService orderService)
        {
  
        }
        #endregion

        #region ACTION RESULT

        #region LIST
        public IActionResult Index()
        {
 
            return View();
        }
        #endregion

        #region UPDATE

        public IActionResult UpdateOrder(int id)
        { 
            return View();
        }

        [HttpPost]
        [ModelStateValidation]
        public IActionResult UpdateOrder(OrderViewModel model)
        {
            return View();
        }

        #endregion

        #region CREATE

        public IActionResult CreateOrder()
        {

            OrderViewModel orderViewModel = new OrderViewModel
            {
                

            };


            return View(orderViewModel);

        }

        [HttpPost]
        [ModelStateValidation]
        public IActionResult CreateOrder(OrderViewModel model)
        {

            return View();

        }
        #endregion

        #region DELETE

        public IActionResult DeleteOrder(int id)
        {
            return View();
        }

        #endregion

        #region DETAIL

        public IActionResult DetailOrder(int id)
        {

            return View();
        }

        #endregion


        #endregion

        #region METHODS
        #endregion

        #region EVENTS
        #endregion


    }
}
