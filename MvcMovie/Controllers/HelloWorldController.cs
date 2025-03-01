﻿using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{

    public class HelloWorldController : Controller
    {
        //
        //GET: /HelloWorld/
        //public string Index()
        //{
        //    return "This is Kim's default action...";
        //}
        //
        // GET: /HelloWorld/Welcome/
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}