using BLL.Interfaces;
using BLL.ModelsDTO;
using Microsoft.AspNetCore.Mvc;

namespace Spotidie.Controllers;

public class ImportDataController : Controller
{
    private readonly ILogger<ImportDataController> _logger;
    private ITrackService _service;

    public ImportDataController(ILogger<ImportDataController> logger, ITrackService service)
    {
        _logger = logger;
        _service = service;
    }
    
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Index(string trackAvatar, string trackName, string playlistName, IFormFile audioFile)
    {
        byte[] imageData = null;
        using (var binaryReader = new BinaryReader(audioFile.OpenReadStream()))
        {
            imageData = binaryReader.ReadBytes((int)audioFile.Length);
        }
        
        var dto = new TrackDTO
        {
            TrackId = Guid.NewGuid(),
            TrackName = trackName,
            TrackDuration = 0,
            TrackData = "imageData",
            TrackDataByte = imageData,
            TrackAvatar = trackAvatar,
            TrackForeignKey = 0,
        };
        _service.CreateTrack(dto);
        return View();
    }
}