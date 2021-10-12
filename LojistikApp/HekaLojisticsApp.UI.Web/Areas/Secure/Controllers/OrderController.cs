using HekaLojisticsApp.Dto.Order;
using HekaLojisticsApp.UI.Web.Areas.Secure.Base;
using Microsoft.AspNetCore.Mvc;

namespace HekaLojisticsApp.UI.Web.Areas.Secure.Controllers
{
    public class OrderController : BaseController
    {

        #region FIELDS
        #endregion

        #region CTOR
        public OrderController()
        {

        }
        #endregion

        #region ACTION RESULTS
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(AddOrderDto order)
        {

            return View();

            
        }

        public IActionResult CreateOrder()
        {

            return View();
        }

        [HttpPost]
        public IActionResult UpdateOrder(UpdateOrderDto order)
        {

            return View();
        }


        public IActionResult UpdateOrder()
        {

            return View();
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View();

        }


        public IActionResult Get()
        {

            return View();

        }

        [HttpGet]
        public IActionResult Get(int id)
        {

            return View();

        }


        [HttpPost]
        public IActionResult Serach(ListOrderDto order)
        {

            return View();

        }

        #endregion


        #region METHODS
        #endregion

        #region EVENTS
        #endregion


    }
}
