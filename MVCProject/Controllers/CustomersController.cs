using Microsoft.AspNetCore.Mvc;

namespace EcommercePortal.Controller;



public class CustomersController : Controller
{
    //action methods:

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