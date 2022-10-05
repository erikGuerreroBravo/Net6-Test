using Microsoft.AspNetCore.Mvc;
using WebTest3.Models;

namespace WebTest3.Controllers
{
    public class DatosPersonalesController : Controller
    {
        [HttpGet]
        public IActionResult RegistrarPersona()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RegistrarPersona([Bind(include: "Nombre,ApellidoPaterno,ApellidoMaterno")] Persona persona)
        {
            TempData["PersonaTemp"] = persona.Nombre + " " + persona.ApellidoPaterno + " " + persona.ApellidoMaterno;
            return RedirectToAction("Index","Manager");
        }
    }
}
