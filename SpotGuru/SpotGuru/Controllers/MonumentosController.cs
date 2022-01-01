using Microsoft.AspNetCore.Mvc;
using SpotGuru.Data;
using System.Collections.Generic;

namespace SpotGuru.Controllers
{
    public class MonumentosController : Controller
    {
        public IActionResult Index()
        {
            List<Models.Monumentos> lstM = new List<Models.Monumentos>();
            MainDAO m = new MainDAO();
            lstM = m.fetchAll();
            return View("Index",lstM);
        }
    }
}
