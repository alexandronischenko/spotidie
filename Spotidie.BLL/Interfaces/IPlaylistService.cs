using BLL.ModelsDTO;
using Spotidie.DAL.Entities;

namespace BLL.Interfaces;

public interface IPlaylistService
{
    Task<PlaylistDTO> GetPlaylist(string id);

    Task CreatePlaylist(PlaylistDTO playlist);

    Task DeletePlaylist(string id);
    IEnumerable<PlaylistDTO> GetPlaylists(string id);

    IEnumerable<PlaylistDTO> GetPlaylists();

    IEnumerable<PlaylistDTO> FindPlaylist(string name);
}