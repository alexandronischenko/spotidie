using AutoMapper;
using BLL.Interfaces;
using BLL.ModelsDTO;
using Microsoft.AspNetCore.Mvc;
using Spotidie.Models;

namespace Spotidie.Controllers;

public class PlaylistViewController : Controller
{
    private IPlaylistService _playlistService;
    private ITrackService _trackService;
    private readonly ILogger<PlaylistViewController> _logger;

    public PlaylistViewController(ILogger<PlaylistViewController> logger, IPlaylistService playlistService, ITrackService trackService)
    {
        _logger = logger;
        _trackService = trackService;
        _playlistService = playlistService;
    }
    
    [HttpGet]
    public Task<IActionResult> PlaylistView(Guid id)
    {
        var result = _playlistService.GetPlaylist(id.ToString()).Result;
        var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PlaylistDTO, PlaylistViewModel>()).CreateMapper();
        var playlist = mapper.Map<PlaylistDTO, PlaylistViewModel>(result);
        
        var trackDtos = _trackService.GetTracks(playlist.PlaylistForeignKey.ToString()).ToList();
        mapper = new MapperConfiguration(cfg => cfg.CreateMap<TrackDTO, TrackViewModel>()).CreateMapper();
        var tracks = mapper.Map<List<TrackDTO>, List<TrackViewModel>>(trackDtos);
        playlist.Tracks = tracks;
        return Task.FromResult<IActionResult>(View(playlist));
    }
}