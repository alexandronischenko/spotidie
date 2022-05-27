using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Spotidie.Controllers;

public class SearchController : Controller
{
    // GET
    private readonly ILogger<SearchController> _logger;
    private IAuthorService _service;

    public SearchController(ILogger<SearchController> logger, IAuthorService service)
    {
        _logger = logger;
        _service = service;
    }
    public IActionResult Search()
    {
        
        return View();
    }
}