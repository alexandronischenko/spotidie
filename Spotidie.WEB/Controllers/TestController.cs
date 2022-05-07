using Spotidie.DAL.Entities;

namespace Spotidie.Controllers;

public class TestController
{
    private IWebHostEnvironment _hostingEnvironment;

    public TestController(IWebHostEnvironment environment) {
        _hostingEnvironment = environment;
    }

    public async Task CreateTrack(TrackViewModel trackVM)
    {
        string trackPath = _hostingEnvironment.WebRootPath + "/Content/Music/" + trackVM.TrackName + trackVM.AuthorId + ".mp3";
        using (Stream fileStream = new FileStream(trackPath, FileMode.Create)) {
            await trackVM.TrackData.CopyToAsync(fileStream);
        }
        
        string trackCoverPath = _hostingEnvironment.WebRootPath + "/Content/TrackCovers/" + trackVM.TrackName + trackVM.AuthorId + ".jpg";
        using (Stream fileStream = new FileStream(trackPath, FileMode.Create)) {
            await trackVM.TrackData.CopyToAsync(fileStream);
        }
        
        var track = new Track
        {
            TrackId = Guid.NewGuid(),
            TrackName = trackVM.TrackName,
            TrackDuration = trackVM.TrackDuration,
            TrackData = trackPath,
            TrackAvatar = trackCoverPath
        }
    }
}