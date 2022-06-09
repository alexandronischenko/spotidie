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
    // GET
    public IActionResult PlaylistView(Guid id)
    {
        PlaylistDTO playlistDto = _playlistService.GetPlaylists().Select(x => x).First(x => x.PlaylistId == id);
        var mapper = new MapperConfiguration(cfg => cfg.CreateMap<PlaylistDTO, PlaylistViewModel>()).CreateMapper();
        var playlist = mapper.Map<PlaylistDTO, PlaylistViewModel>(playlistDto);
        
        IEnumerable<TrackDTO> trackDtos = _trackService.GetTracks(playlistDto.PlaylistForeignKey.ToString());
        mapper = new MapperConfiguration(cfg => cfg.CreateMap<TrackDTO, TrackViewModel>()).CreateMapper();
        var tracks = mapper.Map<IEnumerable<TrackDTO>, List<TrackViewModel>>(trackDtos);
        playlist.Tracks = tracks;
        return View(playlist);
    }
    
}