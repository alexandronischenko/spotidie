using Microsoft.AspNetCore.Mvc;

namespace Spotidie.Controllers;

public class MyMediaController : Controller
{
    // GET
    public IActionResult MyMedia()
    {
        return View();
    }
}