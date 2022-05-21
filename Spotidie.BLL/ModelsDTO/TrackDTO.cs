namespace BLL.ModelsDTO;

public class TrackDTO
{
    public Guid TrackId { get; set; }
    public string TrackName { get; set; }
    public int TrackDuration { get; set; }
    public string TrackData { get; set; }       
    public string TrackAvatar{ get; set; }
    public PlaylistDTO Playlist { get; set; }
    public AuthorDTO Author { get; set; }
}