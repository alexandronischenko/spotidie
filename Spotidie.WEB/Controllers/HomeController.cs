using System.Collections.Immutable;
using System.Diagnostics;
using AutoMapper;
using BLL.Interfaces;
using BLL.ModelsDTO;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Spotidie.Models;

namespace Spotidie.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private IPlaylistService _service;

    public HomeController(ILogger<HomeController> logger, IPlaylistService service)
    {
        _logger = logger;
        _service = service;
    }

    public IActionResult Index()
    {
        var playlistDtos = _service.GetPlaylists().ToList();
        var random = new Random();
        var randomized = playlistDtos.OrderBy(item => random.Next()).ToList();
        
        var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PlaylistDTO, PlaylistViewModel>()).CreateMapper();
        var playlist = mapper.Map<IEnumerable<PlaylistDTO>, List<PlaylistViewModel>>(randomized);
        return View(playlist);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult PrivacySecond()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult SendMail()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SendMail(string name, string email, string phonenumber, string adress, string title, string messagetitle)
    {
        Service.SendEmail(name, email, phonenumber, adress, title, messagetitle);
        
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
    }
}