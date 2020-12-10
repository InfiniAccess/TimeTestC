using Microsoft.AspNetCore.Mvc;
using System;

namespace YourNamespace.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")]       //type of request
        public IActionResult Index()
        {

            DateTime CurrentTime = DateTime.Now;
            ViewBag.CurrentTime = CurrentTime;
            return View();
        }

    }
}