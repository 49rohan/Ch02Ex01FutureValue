﻿using Microsoft.AspNetCore.Mvc;
using FutureValueCh02Ex1.Models;
namespace FutureValueCh02Ex1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            ViewBag.FV = model.CalculateFutureValue();
            return View(model);
        }
      
    }
}
