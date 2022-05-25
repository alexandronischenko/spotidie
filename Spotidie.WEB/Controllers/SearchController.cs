using Microsoft.AspNetCore.Mvc;

namespace Spotidie.Controllers;

public class SearchController : Controller
{
    // GET
    public IActionResult Search()
    {
        return View();
    }
}