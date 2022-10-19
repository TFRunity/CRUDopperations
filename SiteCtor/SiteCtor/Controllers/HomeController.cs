using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SiteCtor.Models;
using SiteCtor.DatabaseMethods;
using SiteCtor.Interfaces;
using SiteCtor.Models.ComparedModels;

namespace SiteCtor.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDBMethods<FirstSiteModel> _dBFirstMethods;
        private readonly IDBMethods<SecondSiteModel> _dBSecondMethods;

        public HomeController(IDBMethods<FirstSiteModel> dBFirstMethods, IDBMethods<SecondSiteModel> dBSecondMethods)
        {
            _dBFirstMethods = dBFirstMethods;
            _dBSecondMethods = dBSecondMethods;
        }
        
        public IActionResult Index()
        {
            List<FirstSiteModel> firstSiteModels = _dBFirstMethods.GetAllObj();
            List<SecondSiteModel> secondSiteModels = _dBSecondMethods.GetAllObj();
            FirstandSecond firstandSecond = new FirstandSecond();
            firstandSecond.firstSite = firstSiteModels;
            firstandSecond.secondSite = secondSiteModels;
            return View(firstandSecond);
        }
    }
}
