using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult IndexText()
        {
             return Content("This is about brands.");
        }

        public IActionResult Private()
        {
            return Json(new { name="text",description="testing Json"});
        }

         public IActionResult Types()
        {
            return  Content("<html><body>Type of brands</body></html>");
        }

        public IActionResult Catalogs()
        {
            return  View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
