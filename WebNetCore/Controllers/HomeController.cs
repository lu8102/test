using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebNetCore.Models;

namespace WebNetCore.Controllers
{
    public class HomeController : Controller
    {
        private ILogger<HomeController> _logger;
        private readonly IServiceProvider _serviceProvider;

        public HomeController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IActionResult Index()
        {
            _logger = (ILogger<HomeController>) _serviceProvider.GetService(typeof(ILogger<HomeController>));
            _logger.LogInformation("テスト");
            return View();
        }
    }
}
