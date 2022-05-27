using Microsoft.AspNetCore.Mvc;

namespace Spotidie.Controllers;

public class SearchController : Controller
{
    // GET
    private readonly ILogger<SearchController> _logger;
    private IAuth _service;

    public SearchController(ILogger<HomeController> logger, IPlaylistService service)
    {
        _logger = logger;
        _service = service;
    }
    public IActionResult Search()
    {
        
        return View();
    }
}