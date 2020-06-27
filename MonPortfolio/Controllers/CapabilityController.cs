
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using MonPortfolio.Models;
using System.Linq;

namespace MonPortfolio.Controllers
{
    public class CapabilityController : Controller
    {
        private Database m_database { get; set; }

        public CapabilityController(Database database)
        {
            m_database = database;
        }
        public IActionResult PresentationPage()
        {
            var data = m_database.ListCapabilities;
            

            return View(data);
        }

        public IActionResult AboutSkill(int id)
        {
            var data = m_database.ListCapabilities.Where(p => p.SkillId == id).SingleOrDefault();

            return View(data);
        }
    }
}