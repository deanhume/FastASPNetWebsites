using System.Threading;
using System.Web.Mvc;

namespace SurfStoreApp.Controllers
{
    public class StatisticsController : Controller
    {
        public ActionResult Update()
        {
            // Do something intensive here
            Thread.Sleep(5000);

            return Json("Success", JsonRequestBehavior.AllowGet);
        }
    }
}
