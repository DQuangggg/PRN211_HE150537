using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.Controllers
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
        //           HomeModel message = new HomeModel();
        //           return View(message);
             
         //          ViewData["Greating"] = "Hello ";
         //          return View("Index");
            
            //VIEW BAG
            ViewBag.Message = "Hello Bag";
            ViewBag.Model = new HomeModel
            {
                ProductID = 1,
                ProductName = "Galaxy",
                Brand = "Samsaung",
                Price = 20000
            };

            //TEMP DATA
            List<string> listStudent = new List<string>();
            listStudent.Add("John");
            listStudent.Add("Samrat");
            listStudent.Add("David");
            TempData["StudentData"] = listStudent;

            //SESSION
      //      HttpContext.Session.SetString("Product","Laptop");

            return View();
           
        }

 //       [Route("Home/DemoSession")]

        //public IActionResult DemoSession()
        //{
        //    ViewBag.Data = HttpContext.Session.GetString("Product");
        //    return View();
        //}
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //QUERY STRING
        //public ActionResult Index(int code, string strName, string strDepartment) {
        //    string strResult = $"Id = {code} , Name = {strName} , Department = {strDepartment} ";
        //    return Content(strResult);
               
        //}

    }

   
}
