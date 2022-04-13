using Microsoft.AspNetCore.Mvc;

namespace Spotidie.Controllers.Authentication;

public class AuthenticationController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }
}