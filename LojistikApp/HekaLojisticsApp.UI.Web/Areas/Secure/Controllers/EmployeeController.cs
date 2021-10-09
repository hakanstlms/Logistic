using HekaLojisticsApp.UI.Web.Areas.Secure.Base;
using Microsoft.AspNetCore.Mvc;

namespace HekaLojisticsApp.UI.Web.Areas.Secure
{
    public class EmployeeController : BaseController
    {

        #region FIELDS
        #endregion

        #region CTOR

        #endregion

        #region ACTION RESULT
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CreateEmployee()
        {
            return View();
        }


        #endregion

        #region METHODS



        #endregion

        #region EVENTS
        #endregion    }
    }
}