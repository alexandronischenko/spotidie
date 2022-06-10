using AutoMapper;
using BLL.Interfaces;
using BLL.ModelsDTO;
using Spotidie.DAL.Entities;
using Spotidie.DAL.Interfaces;

namespace BLL.Services;

public class TrackService : ITrackService
{
    private ITrackService _trackServiceImplementation;

    public TrackService(IUnitOfWork db)
    {
        Db = db;
    }

    private IUnitOfWork Db { get; set; }
    
    public TrackDTO GetTrack(string id)
    {
        if (id == null)
            throw new Exception("id is null");
        var track = Db.Tracks.Get(Guid.Parse(id));

        if (track == null)
            throw new Exception("Track not found");

        return DTOMapper.MapTrack(track);
    }

    public IEnumerable<TrackDTO> GetTracks(string id)
    {
        if (id == null)
            throw new Exception("id is null");
        var tracks = Db.Tracks.GetAll();
        tracks = tracks.Select(x=>x).Where(x => x.TrackForeignKey.ToString() == id);

        var result = new List<TrackDTO>();
        
        foreach (var track in tracks)
        {
            result.Add(DTOMapper.MapTrack(track));
        }

        return result;
    }
    
    public IEnumerable<TrackDTO> FindTrack(string? name)
    {
        if (name == null)
            throw new Exception("name is null");
        var tracks = Db.Tracks.Find(x => x.TrackName.ToLower().Contains(name.ToLower()));

        var result = new List<TrackDTO>();
        
        foreach (var track in tracks)
        {
            result.Add(DTOMapper.MapTrack(track));
        }

        return result;
    }

    public async Task CreateTrack(TrackDTO trackDTO)
    {
        if (trackDTO == null)
            throw new Exception("Track is null");
        
        var config = new MapperConfiguration(cfg => cfg.CreateMap<TrackDTO, Track>());
        var mapper = new Mapper(config);
        var track = mapper.Map<TrackDTO, Track>(trackDTO);
        Db.Tracks.Create(track);
    }

    public async Task DeleteTrack(string id)
    {
        if (id == null)
            throw new Exception("Id is null");
        Db.Tracks.Delete( Guid.Parse(id));
    }
}