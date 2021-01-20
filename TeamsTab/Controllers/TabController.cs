using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TeamsTab.Models;

namespace TeamsTab.Controllers
{
    public class TabController : Controller
    {
        private readonly ILogger<TabController> _logger;

        public TabController(ILogger<TabController> logger)
        {
            _logger = logger;
        }

        public IActionResult Configuration()
        {
            return View();
        }

        public IActionResult Content()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}