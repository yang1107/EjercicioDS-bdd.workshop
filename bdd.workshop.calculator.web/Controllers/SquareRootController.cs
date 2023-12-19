using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bdd.workshop.calculator.web.Controllers
{
    public class SquareRootController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SquareRoot(Models.SquareRoot squareRoot)
        {
            ViewData["a"] = squareRoot.A.TheNumber;
            ViewData["result"] = Operator.SquareRoot(squareRoot.A.TheNumber);
            return View();
        }
    }
}
