using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

using Dominio.Entidad.Negocio.Abstraccion;
using Dominio.Entidad.Negocio.Entidad;

namespace EFSRT_DELONNY.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Console.Beep(); // hice este cambio eliminalo dsps






            //cambio solo en la RAMA MAIN SOLO ACA DEBE MOSTRARSE

            Categoria categoria = new Categoria
            {
                codigo = "001",
                nombre = "Categoria 1"
            };
            // Aquí podrías hacer algo con la categoría, como guardarla en una base de datos o mostrarla en la vista.
            ViewBag.Categoria = categoria;

            Empleado empleado = new Empleado();
            empleado.IdArtefacto = "12345";

            // Aquí podrías hacer algo con el empleado, como guardarlo en una base de datos o mostrarlo en la vista.
            ViewBag.Empleado = empleado;


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