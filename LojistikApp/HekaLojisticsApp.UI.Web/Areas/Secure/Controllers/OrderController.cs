using HekaLojisticsApp.UI.Web.Areas.Secure.Base;
using HekaLojisticsApp.UI.Web.Models.Order;
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
        public IActionResult CreateOrder(OrderViewModel order)
        {

            return View();


        }

        public IActionResult CreateOrder()
        {

            return View();
        }

        [HttpPost]
        public IActionResult UpdateOrder(OrderViewModel order)
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


        public IActionResult Detail()
        {

            return View();

        }

        [HttpGet]
        public IActionResult Detail(int id)
        {

            return View();

        }


        [HttpPost]
        public IActionResult Search(OrderViewModel order)
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
