using Microsoft.AspNetCore.Http;

namespace BLL.Interfaces;

public interface IDownloadService
{
    Task UploadAudioFile(IFormFile audioFile);
}