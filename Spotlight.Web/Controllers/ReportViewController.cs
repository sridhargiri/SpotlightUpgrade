using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spotlight.Web.Controllers
{
    public class ReportViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
