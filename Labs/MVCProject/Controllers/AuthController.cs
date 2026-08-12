using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace MVCProject.Controllers;

public class AuthController : Controller
{
    //its a action Methods;

    public IActionResult Login()
    {
        return View();

    }


    public IActionResult Register()
    {
        return View();
    }


    public IActionResult changePassword()
    {
        return View();

    }

}