using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GTech_Presentation.Controllers
{
    public class ReconcileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string connectionString()
        {
            string connString = Helper.ConfigurationHelper.getConnectionString();

            return connString;
        }
    }
}
