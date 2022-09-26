using CaremetxAnagramExercise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CaremetxAnagramExercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CheckAnagram(string text1, string text2)
        {
            //value entered should be correct
            if( text1 == null || text2 == null || text1.Trim()=="" || text2.Trim()=="")
            {
                ViewBag.color = "orange";
                ViewBag.Wrong = "Wrong values entered !!!";
            }
            else
            {
                TextInput input = new TextInput(text1.Trim(), text2.Trim());
                ViewBag.Text = input;
                if (input.AreAnagram())
                {
                    ViewBag.response = " are Anagrams";
                    ViewBag.color = "green";
                }
                else
                {
                    ViewBag.response = " are not Anagrams";
                    ViewBag.color = "red";

                }
            }
            

            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
