using HekaLojisticsApp.UI.Web.Filters;
using Microsoft.AspNetCore.Mvc;

namespace HekaLojisticsApp.UI.Web.Areas.Secure.Base
{

    [Area("Secure")]
    [TypeFilter(typeof(ExceptionFilter))]
    public class BaseController : Controller
    {
        public BaseController()
        {

        }
    
    }
}
