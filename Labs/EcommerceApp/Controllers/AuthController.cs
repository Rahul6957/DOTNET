using Microsoft.AspNetCore.Mvc;

using ECommercePortal.Models;
namespace ECommercePortal.Controllers;

public class AuthController : Controller
{
    
    //action methods:


    [HttpGet] //get login page it show login page
    public IActionResult Login()
    {
        Credential credential = new Credential();
        credential.UserName = "Rahul";
        credential.Password = "Rahul";

        return View(credential);
    }

    [HttpPost]  //login bution click kel ki to taklel password check
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


    [HttpGet] // register page aantoy 
    public IActionResult Register()
    {

        Customer customer = new Customer();
        customer.Name = "";
        customer.Email = "";
        customer.Phone = "";
        customer.Id =2;

        return   View(customer);
    }

    [HttpPost] // e
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