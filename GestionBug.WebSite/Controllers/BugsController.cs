using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GestionBug.WebSite.Controllers
{
    public class BugsController : Controller
    {
        private String connectionString;
        public BugsController(IConfiguration configRoot)
        {
            connectionString = configRoot["ConnectionString:DefaultConnection"];
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}