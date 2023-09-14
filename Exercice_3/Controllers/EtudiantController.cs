using Microsoft.AspNetCore.Mvc;
using Exercice_3.Models;

namespace Exercice_3.Controllers
{
    public class EtudiantController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Etudiant etudiant)
        {
            return Content(etudiant.Nom);
        }
    }
}
