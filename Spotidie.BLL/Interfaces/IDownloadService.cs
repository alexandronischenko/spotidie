using Microsoft.AspNetCore.Http;

namespace BAL.Interfaces;

public interface IDownloadService
{
    Task UploadAudioFile(IFormFile audioFile);
}