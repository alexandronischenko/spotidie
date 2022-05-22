namespace Spotidie.Models;

public class TrackViewModel
{
    public Guid TrackId { get; set; }
    public string TrackName { get; set; }
    public int TrackDuration { get; set; }
    public string TrackData { get; set; }       
    public string TrackAvatar{ get; set; }
    public PlaylistViewModel Playlist { get; set; }
    public AuthorViewModel Author { get; set; }
}