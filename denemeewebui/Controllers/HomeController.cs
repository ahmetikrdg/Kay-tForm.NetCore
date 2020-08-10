using System;
using denemeewebui.Data;
using denemeewebui.Models;
using Microsoft.AspNetCore.Mvc;

namespace denemeewebui.Controllers
{
    public class HomeController:Controller
    {
        public object ProductRepository { get; private set; }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]

        public IActionResult Create()
        {
            return View(new Person());
        }
        
        [HttpPost]

        public IActionResult Create(Person P)
        {
            PersonRepository.AddProduct(P);
            return RedirectToAction("Index");
        }


    }
}