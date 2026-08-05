using Microsoft.AspNetCore.Mvc;

using ECommercePortal.Models;
namespace ECommercePortal.Controllers;

public class AuthController : Controller
{
    
    //action methods:


    [HttpGet]
    public IActionResult Login()
    {
        Credential credential = new Credential();
        credential.UserName = "Rahul";
        credential.Password = "Rahul";

        return View(credential);
    }

    [HttpPost]
    public IActionResult Login(Credential credential)
    {
        if(credential.UserName=="admin" && credential.Password=="transflower")
        {
            return RedirectToAction("Welcome", "Home");
        }
        else
        {
            ViewData["Message"] = "Invalid User Name or Password";
            return View();
        }
    }


    [HttpGet]
    public IActionResult Register()
    {

        Customer customer = new Customer();
        customer.Name = "";
        customer.Email = "";
        customer.Phone = "";
        customer.Id =2;

        return   View(customer);
    }

    [HttpPost]
    public IActionResult Register(Customer customer)
    {
        //Logic to register a new user
        //store it inside json file or database


        return  RedirectToAction("Login");
    }

    public IActionResult ChangePassword()
    {
        return View();
    }
}