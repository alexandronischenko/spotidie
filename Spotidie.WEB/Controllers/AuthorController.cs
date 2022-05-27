using AutoMapper;
using BLL.Interfaces;
using BLL.ModelsDTO;
using Microsoft.AspNetCore.Mvc;
using Spotidie.Models;

namespace Spotidie.Controllers;

public class AuthorController : Controller
{
    private readonly ILogger<AuthorController> _logger;
    private IAuthorService _service;
    
    public AuthorController(ILogger<AuthorController> logger, IAuthorService service)
    {
        _logger = logger;
        _service = service;
    }
    // GET
    public IActionResult Author()
    {
        IEnumerable<AuthorDTO> authorsDtos = _service.GetAuthors();
        var mapper = new MapperConfiguration(cfg => cfg.CreateMap<AuthorDTO, AuthorViewModel>()).CreateMapper();
        var author = mapper.Map<IEnumerable<AuthorDTO>, List<AuthorViewModel>>(authorsDtos).First();
        return View(author);
    }
}