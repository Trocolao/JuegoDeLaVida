using JuegoDeLaVida.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace JuegoDeLaVida.MVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Saludar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Saludar(Persona persona)
        {
            
            return View("Sal",persona);
        }
    }
}
