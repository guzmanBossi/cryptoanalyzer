using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ALoGaucho.CryptoAnalyzer.Domain.Services;

namespace ALoGaucho.CryptoAnalyzer.ApiHost.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITrendsService _trendsService;

        public HomeController(ITrendsService trendsService)
        {
            _trendsService = trendsService;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            
            return View();
        }
    }
}
