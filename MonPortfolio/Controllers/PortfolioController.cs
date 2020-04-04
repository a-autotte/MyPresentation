
using Microsoft.AspNetCore.Mvc;
using MonPortfolio.Models;

namespace MonPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult PresentationPage()
        {
            var databaseTechnology = new technologiesDatabase();
            var databaseData = databaseTechnology.ObtainTechnologiesInformation();

            return View(databaseData);
        }
    }
}