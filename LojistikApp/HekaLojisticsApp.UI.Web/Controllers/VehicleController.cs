using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HekaLojisticsApp.UI.Web.Controllers
{
    public class VehicleController:Controller
    {




        public VehicleController()
        {

        }



        public IActionResult Index()
        {

            

            return View();
        }



    }
}
