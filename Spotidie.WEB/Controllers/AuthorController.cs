using AutoMapper;
using BLL.Interfaces;
using BLL.ModelsDTO;
using Microsoft.AspNetCore.Mvc;
using Spotidie.Models;

namespace Spotidie.Controllers;

public class AuthorController : Controller
{
    private readonly ILogger<AuthorController> _logger;
    private IAuthorService _authorService;
    private ITrackService _trackService;
    private IPlaylistService _playlistService;

    public AuthorController(ILogger<AuthorController> logger, IAuthorService authorService, ITrackService trackService, IPlaylistService playlistService)
    {
        _logger = logger;
        _authorService = authorService;
        _trackService = trackService;
        _playlistService = playlistService;
    }

    // GET
    public IActionResult Author()
    {
        IEnumerable<AuthorDTO> authorsDtos = _authorService.GetAuthors();
        var mapper = new MapperConfiguration(cfg => cfg.CreateMap<AuthorDTO, AuthorViewModel>()).CreateMapper();
        var author = mapper.Map<IEnumerable<AuthorDTO>, List<AuthorViewModel>>(authorsDtos).ElementAt(3);

        IEnumerable<TrackDTO> trackDtos = _trackService.GetTracks(author.AuthorForeignKey.ToString());
        mapper = new MapperConfiguration(cfg => cfg.CreateMap<TrackDTO, TrackViewModel>()).CreateMapper();
        var tracks = mapper.Map<IEnumerable<TrackDTO>, List<TrackViewModel>>(trackDtos);
        author.Tracks = tracks;
        
        IEnumerable<PlaylistDTO> playlistDtos = _playlistService.GetPlaylists(author.AuthorForeignKey.ToString());
        mapper = new MapperConfiguration(cfg => cfg.CreateMap<PlaylistDTO, PlaylistViewModel>()).CreateMapper();
        var playlist = mapper.Map<IEnumerable<PlaylistDTO>, List<PlaylistViewModel>>(playlistDtos);
        author.Playlists = playlist;

        return View(author);
    }
}