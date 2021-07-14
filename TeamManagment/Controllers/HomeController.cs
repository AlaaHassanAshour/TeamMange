using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TeamManagment.Models;
using TeamManagment.Models.Interfaces;

namespace TeamManagment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ICompany ic;
        public HomeController(ILogger<HomeController> logger, ICompany ic)
        {
            _logger = logger;
            this.ic = ic;
        }

        public IActionResult Index()
        {
            return View(ic.GetCompanyInfromation(1));
        }

        public IActionResult Privacy()
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
