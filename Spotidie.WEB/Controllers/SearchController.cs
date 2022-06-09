using AutoMapper;
using BLL.Interfaces;
using BLL.ModelsDTO;
using Microsoft.AspNetCore.Mvc;
using Spotidie.Models;

namespace Spotidie.Controllers;

public class SearchController : Controller
{
    private readonly ILogger<SearchController> _logger;
    private IAuthorService _authorService;
    private ITrackService _trackService;
    private IPlaylistService _playlistService;
    private SearchViewModel _searchViewModel = new SearchViewModel();

    public SearchController(ILogger<SearchController> logger, IAuthorService authorService, ITrackService trackService, IPlaylistService playlistService)
    {
        _logger = logger;
        _authorService = authorService;
        _trackService = trackService;
        _playlistService = playlistService;
    }
    
    [HttpGet]
    public IActionResult Search()
    {
        return View(_searchViewModel);
    }
    
    [HttpGet]
    public JsonResult SearchResult()
    {
        return Json(_searchViewModel);
    }
    
    [HttpPost]
    public JsonResult Search(string searchString)
    {
        if (searchString == "")
        {
            return (Json(_searchViewModel));
        }
        var result = _trackService.FindTrack(searchString);
        var mapper = new MapperConfiguration(cfg => cfg.CreateMap<TrackDTO, TrackViewModel>()).CreateMapper();
        var tracks = mapper.Map<IEnumerable<TrackDTO>, List<TrackViewModel>>(result).ToList();
        _searchViewModel.Tracks = tracks;
        
        var playlistDtos = _playlistService.FindPlaylist(searchString);
        mapper = new MapperConfiguration(cfg => cfg.CreateMap<PlaylistDTO, PlaylistViewModel>()).CreateMapper();
        var playlists = mapper.Map<IEnumerable<PlaylistDTO>, List<PlaylistViewModel>>(playlistDtos);
        _searchViewModel.Playlists = playlists;
        
        var authorDtos = _authorService.FindAuthor(searchString);
        mapper = new MapperConfiguration(cfg => cfg.CreateMap<AuthorDTO, AuthorViewModel>()).CreateMapper();
        var authors = mapper.Map<IEnumerable<AuthorDTO>, List<AuthorViewModel>>(authorDtos);
        _searchViewModel.Authors = authors;
        
        
        return new JsonResult(PartialView(_searchViewModel));
        return Json(_searchViewModel);
    }
}