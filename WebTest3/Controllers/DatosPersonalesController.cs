using Microsoft.AspNetCore.Mvc;
using WebTest3.Models;

namespace WebTest3.Controllers
{
    public class DatosPersonalesController : Controller
    {
        [HttpGet]
        public IActionResult RegistrarPersona()
        {
            TempData["Direccion"] = TempData["DireccionTemp"];
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegistrarPersona([Bind(include: "Nombre,ApellidoPaterno,ApellidoMaterno")] Persona persona)
        {
            string direccion = TempData["Direccion"].ToString();
            TempData["PersonaTemp"] = persona.Nombre + " " + persona.ApellidoPaterno + " " + persona.ApellidoMaterno +" "+ direccion;
            return RedirectToAction("Index","Manager");
        }
    }
}
