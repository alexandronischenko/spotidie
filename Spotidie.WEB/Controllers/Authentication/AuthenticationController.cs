using Microsoft.AspNetCore.Mvc;

namespace Spotidie.Controllers.Authentication;

public class AuthenticationController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<ActionResult> Register()
    {
        return View();
    }
}