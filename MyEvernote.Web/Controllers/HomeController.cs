using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEvernote.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            /* Bu kısım dbcontext ilk halindeyken ki test ettiğimiz komutlar.
            BusinessLayer.DBCreatedOn dBCreatedOn = new BusinessLayer.DBCreatedOn();
            dBCreatedOn.Insert_Test();
            dBCreatedOn.Update_Test();
            dBCreatedOn.Delete_Test();
            dBCreatedOn.Insert_Comment();
            */

            return View();
        }
    }
}