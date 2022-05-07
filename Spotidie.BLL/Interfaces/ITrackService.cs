using BAL.ModelsDTO;
using Spotidie.DAL.Entities;

namespace BAL.Interfaces;

public interface ITrackService
{
    Task<TrackDTO> GetTrack(string id);

    Task CreateTrack(TrackDTO track);

    Task DeleteTrack(string id);
}