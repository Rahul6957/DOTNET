using Microsoft.AspNetCore.Mvc;

namespace EcommercePortal.Controller;
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