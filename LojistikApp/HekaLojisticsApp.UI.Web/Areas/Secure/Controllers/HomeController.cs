using HekaLojisticsApp.UI.Web.Areas.Secure.Base;
using Microsoft.AspNetCore.Mvc;

namespace HekaLojisticsApp.UI.Web.Areas.Secure
{
   
    public class HomeController : BaseController
    {
       
        #region FIELDS
        #endregion

        #region CTOR
        public HomeController()
        {

        }
        #endregion

        #region ACTION RESULT
        public IActionResult Index()
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
