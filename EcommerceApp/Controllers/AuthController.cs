using Microsoft.AspNetCore.Mvc;

using EcommercePortal.Models;
using System.Net;
namespace ECommercePortal.Controllers;


public class AuthController : Controller
{
    //action methods

    [HttpGet]

    public IActionResult login()
    {
        Credential credential = new credential();
        credential.UserName = "Rahul";
        credential.Password = "Rahul";

        return View(credential);

        [HttpPost]
         public IActionResult Login(Credential credential)

    }{
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