using HekaLojisticsApp.UI.Web.Areas.Secure.Base;
using Microsoft.AspNetCore.Mvc;

namespace HekaLojisticsApp.UI.Web.Areas.Secure.Controllers
{
    public class AgendaController : BaseController
    {


        #region FIELDS
        #endregion

        #region CTOR
        public AgendaController()
        {

        }

        #endregion

        #region ACTION RESULTS
        public IActionResult Index()
        {
            return View();
        }

        #endregion

        #region METHODS
        #endregion



    }
}
