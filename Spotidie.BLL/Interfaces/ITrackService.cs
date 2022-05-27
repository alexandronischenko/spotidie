using BLL.ModelsDTO;
using Spotidie.DAL.Entities;

namespace BLL.Interfaces;

public interface ITrackService
{
    TrackDTO GetTrack(string id);
    
    IEnumerable<TrackDTO> GetTracks(string id);

    Task CreateTrack(TrackDTO track);

    Task DeleteTrack(string id);
}