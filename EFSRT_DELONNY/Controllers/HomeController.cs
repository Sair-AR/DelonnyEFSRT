using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace EFSRT_DELONNY.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Console.Beep(); // hice este cambio eliminalo dsps




            //ESTE CAMBIO SOLO DEBE SER VISUALZIADO EN LA TERCEERA RAMA "eliminar-rama-Victor"

            Console.WriteLine("Este es un cambio que solo debe ser visualizado en la rama eliminar-rama-Victor");
            return View();
         
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}