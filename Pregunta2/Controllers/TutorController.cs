using Microsoft.AspNetCore.Mvc;
using Pregunta2.Models;
using System.Collections.Generic;

namespace Pregunta2.Controllers
{
    public class TutorController : Controller
    {
        private static List<Tutor> Tutores = new List<Tutor>();
        public ActionResult ListaTutores()
        {
            return View(Tutores);
        }

        // GET: Tutor
        public ActionResult FrmTutor()
        {
            return View(new Tutor());
        }

        [HttpPost]
        public ActionResult FrmTutor(Tutor reg)
        {
            if (ModelState.IsValid) // Verificar la validez del modelo
            {
                Tutores.Add(reg);
                ViewBag.Mensaje = "Tutor registrado correctamente.";
                ViewBag.TotalTutores = Tutores.Count; // Pasar el conteo de tutores registrados
                ModelState.Clear(); // Limpiar los campos del formulario
                return View(new Tutor()); // Retornar un nuevo objeto Tutor para una nueva entrada
            }
            return View(reg);
        }

        
    }
}
