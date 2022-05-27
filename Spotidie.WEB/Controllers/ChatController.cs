using Microsoft.AspNetCore.Mvc;

namespace Spotidie.Controllers;

public class ChatController : Controller
{
    // GET
    public IActionResult Chat()
    {
        return View();
    }
}