using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CertifiedGrinder.Controllers
{
    public class FinancialsController : Controller
    {
        public IActionResult Financials()
        {
            return View();
        }
    }
}