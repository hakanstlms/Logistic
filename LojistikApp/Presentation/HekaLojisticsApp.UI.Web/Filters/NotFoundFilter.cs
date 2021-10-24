using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace HekaLojisticsApp.UI.Web.Filters
{
    public class NotFoundFilter : ActionFilterAttribute
    {


        #region FIELDS
        #endregion

        #region CTOR
        public NotFoundFilter()
        {

        }

        #endregion

        #region METHODS

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            int id = (int)context.ActionArguments.Values.FirstOrDefault();


            base.OnActionExecuting(context);
        }
        #endregion

        #region EVENTS
        #endregion



    }
}
