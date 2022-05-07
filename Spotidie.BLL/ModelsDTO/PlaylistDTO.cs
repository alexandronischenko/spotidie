namespace BAL.ModelsDTO;

public class PlaylistDTO
{
    public Guid PlaylistId { get; set; }
    public string PlaylistName { get; set; }       
    public byte[] PlaylistAvatar { get; set; }
    public UserDTO User { get; set; }
    public List<TrackDTO> Tracks { get; set; }
}