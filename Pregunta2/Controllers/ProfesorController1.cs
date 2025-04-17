using Microsoft.AspNetCore.Mvc;
using Pregunta2.Models;

namespace Pregunta2.Controllers
{
    public class ProfesorController : Controller
    {
        [HttpGet]
        public ActionResult FrmProfesor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FrmProfesor (Profesor reg)
        {
            ViewBag.ObtenerSueldoBasico = reg.ObtenerSueldoBasico();
                return View(reg);

        }
    }
}
