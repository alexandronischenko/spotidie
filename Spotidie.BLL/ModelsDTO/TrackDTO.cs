namespace BAL.ModelsDTO;

public class TrackDTO
{
    public Guid TrackId { get; set; }
    public string TrackName { get; set; }
    public int TrackDuration { get; set; }
    public byte[] TrackData { get; set; }       
    public byte[] TrackAvatar{ get; set; }
    public PlaylistDTO Playlist { get; set; }
    public AuthorDTO Author { get; set; }
}