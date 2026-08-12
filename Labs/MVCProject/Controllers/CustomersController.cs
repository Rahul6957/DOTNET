using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;


namespace MVCProject.Controllers;


public class CustomersController :  Controller
{
    public IActionResult Index()
    {
        return View();

    }
    public ActionResult Aboutus()
    {
        return View();

    }

    public IActionResult ContactUs()
    {
        return View();
        
    }
}