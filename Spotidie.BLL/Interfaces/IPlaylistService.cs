using BAL.ModelsDTO;
using Spotidie.DAL.Entities;

namespace BAL.Interfaces;

public interface IPlaylistService
{
    Task<PlaylistDTO> GetPlaylist(string id);

    Task CreatePlaylist(PlaylistDTO playlist);

    Task DeletePlaylist(string id);
}