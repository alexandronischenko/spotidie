using AutoMapper;
using BLL.Interfaces;
using BLL.ModelsDTO;
using Spotidie.DAL.Entities;
using Spotidie.DAL.Interfaces;

namespace BLL.Services;

public class PlaylistService : IPlaylistService
{
    
    public PlaylistService(IUnitOfWork db)
    {
        Db = db;
    }

    private IUnitOfWork Db { get; set; }
    
    public async Task<PlaylistDTO> GetPlaylist(string id)
    {
        if (id == null)
            throw new Exception("Id is null");

        var playlist = Db.Playlists.Get(Guid.Parse(id));

        if (playlist == null)
            throw new Exception("Playlist not found");

        return DTOMapper.MapPlaylist(playlist);
    }

    public async Task CreatePlaylist(PlaylistDTO playlistDTO)
    {
        if (playlistDTO == null)
            throw new Exception("Object is empty");
        
        var config = new MapperConfiguration(cfg => cfg.CreateMap<PlaylistDTO, Playlist>());
        var mapper = new Mapper(config);
        var playlist = mapper.Map<PlaylistDTO, Playlist>(playlistDTO);
        Db.Playlists.Create(playlist);
    }

    public async Task DeletePlaylist(string id)
    {
        if (id == null)
            throw new Exception("Id is null");
        
        Db.Playlists.Delete(Guid.Parse(id));
    }

    public IEnumerable<PlaylistDTO> GetPlaylists(string id)
    {
        var playlists = Db.Playlists.GetAll();
        playlists = playlists.Select(x=>x).Where(x => x.PlaylistForeignKey.ToString() == id);
                if (playlists == null)
            throw new Exception("Playlist not found");

        List<PlaylistDTO> result = new List<PlaylistDTO>();

        foreach (var playlist in playlists)
        {
            result.Add(DTOMapper.MapPlaylist(playlist));
        }

        return result;
    }
    
    public IEnumerable<PlaylistDTO> GetPlaylists()
    {
        var playlists = Db.Playlists.GetAll();
        if (playlists == null)
            throw new Exception("Playlist not found");

        List<PlaylistDTO> result = new List<PlaylistDTO>();

        foreach (var playlist in playlists)
        {
            result.Add(DTOMapper.MapPlaylist(playlist));
        }

        return result;
    }
}