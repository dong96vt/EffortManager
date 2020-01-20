using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SomeThingManager.Models;

namespace SomeThingManager.Controllers
{
    public class RevenueExpenditureController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}