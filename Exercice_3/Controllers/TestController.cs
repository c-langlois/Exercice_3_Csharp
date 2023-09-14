using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Http;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;

namespace Exercice_3.Controllers
{
    public class TestController : Controller
    {
        public IActionResult TesterTéléchargement()
        {
            return File("~/Documents/420B0-2017-A20.pdf", "application/pdf");
        }

        public IActionResult TesterRedirectionExterne()
        {
            return Redirect("https://www.cstjean.qc.ca/");
        }

        public IActionResult TesterContenu()
        {
            return Content("Test de contenu");
        }

        public IActionResult TesterRedirectionVersAction()
        {
            return RedirectToAction("TesterContenu");
        }

        public IActionResult TesterRoute(string prénom, string nom)
        {
            
            return Content("Bonjour " + prénom + " " + nom);
        }

        public IActionResult TesterSession()
        {
            int compteur = HttpContext.Session.GetInt32("Compteur").GetValueOrDefault();
            HttpContext.Session.SetInt32("Compteur", ++compteur);
            return Content("<meta charset='utf-8'><h1 style='font-family:Arial'>La méthode d'action TesterSession a été exécutée " + compteur + " fois.</h1>", "text/html");
        }
    }
}
