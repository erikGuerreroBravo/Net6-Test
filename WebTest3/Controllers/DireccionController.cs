using Microsoft.AspNetCore.Mvc;
using WebTest3.Models;

namespace WebTest3.Controllers
{
    public class DireccionController : Controller
    {
        public IActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registrar([Bind(include:"Calle,Colonia,CodigoPostal,NumeroInterior")]Direccion  direccion )
        {
            var direccionCompleta = direccion.Calle +" "+direccion.Colonia+" "+direccion.CodigoPostal;
            TempData["DireccionTemp"] = direccionCompleta.ToString();
            return RedirectToAction("RegistrarPersona", "DatosPersonales");
        }


    }
}
