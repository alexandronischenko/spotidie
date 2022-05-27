using BLL.ModelsDTO;
using Spotidie.DAL.Entities;

namespace BLL.Interfaces;

public interface ITrackService
{
    TrackDTO GetTrack(string id);
    
    IEnumerable<TrackDTO> GetTracks(string id);

    IEnumerable<TrackDTO> FindTrack(string name);

    Task CreateTrack(TrackDTO track);

    Task DeleteTrack(string id);
}