using Microsoft.AspNetCore.Mvc;
using SiteCtor.Interfaces;
using SiteCtor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteCtor.Controllers
{
    public class FirstController : Controller
    {
        private readonly IDBMethods<FirstSiteModel> _dBmethods;
        public bool IsTrue { get; set; }
        public FirstController(IDBMethods<FirstSiteModel> dBMethods)
        {
            _dBmethods = dBMethods;
        }
        public IActionResult List()
        {
            
            List<FirstSiteModel> firstSiteModels = _dBmethods.GetAllObj();
            return View(firstSiteModels);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(FirstSiteModel firstSiteModel)
        {
            _dBmethods.CreateObj(firstSiteModel);
            return RedirectToAction(nameof(List));
        }
        [HttpGet]
        public IActionResult Edit(FirstSiteModel oldSitemodel)
        {
            return View(oldSitemodel);
        }
        [HttpPost]
        //Не изменить, по соображениям безопасности данных
        public IActionResult Edit(FirstSiteModel firstSiteModel, FirstSiteModel oldSitemodel)
        {
            _dBmethods.UpdateObj(firstSiteModel, oldSitemodel);
            return RedirectToAction(nameof(List));
        }
        public IActionResult Delete(FirstSiteModel deletingSiteModel)
        {
            return View(deletingSiteModel);
        }
        public IActionResult DeleteConfirmed(FirstSiteModel deletingSiteModel)
        {   
            _dBmethods.DeleteObj(deletingSiteModel);
            return RedirectToAction(nameof(List));
        }
    }
}
