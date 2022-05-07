namespace Spotidie.Utils;

public class UploadManager
{
    
    private IWebHostEnvironment _hostingEnvironment;

    public UploadManager(IWebHostEnvironment environment) {
        _hostingEnvironment = environment;
    }
    
    public async Task<string> UploadTrack(IFormFile track, Guid trackId)
    {
        string trackPath = _hostingEnvironment.WebRootPath + "/Content/Music/" + track.FileName + trackId + ".mp3";
        using (Stream fileStream = new FileStream(trackPath, FileMode.Create)) {
            await track.CopyToAsync(fileStream);
        }

        return trackPath;
    }

    public async Task<string> UploadTrackCover(IFormFile trackCover, Guid trackId)
    {
        string trackCoverPath = _hostingEnvironment.WebRootPath + "/Content/TrackCovers/" + trackCover.FileName + trackId + ".jpg";
        using (Stream fileStream = new FileStream(trackCoverPath, FileMode.Create)) {
            await trackCover.CopyToAsync(fileStream);
        }

        return trackCoverPath;
    }

    public async Task<string> UploadUserAvatar(IFormFile avatar, Guid userId)
    {
        string userAvatarPath = _hostingEnvironment.WebRootPath + "/Content/UserAvatars/" + avatar.FileName + userId + ".jpg";
        using (Stream fileStream = new FileStream(userAvatarPath, FileMode.Create)) {
            await avatar.CopyToAsync(fileStream);
        }

        return userAvatarPath;
    }
}