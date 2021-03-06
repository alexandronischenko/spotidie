namespace Spotidie.Models;

public class AuthorViewModel
{
    public Guid AuthorId { get; set; }
    public string AuthorName { get; set; }
    public string AuthorAvatar { get; set; }
    
    public int AuthorForeignKey { get; set; }
    public List<TrackViewModel> Tracks { get; set; }

    public List<PlaylistViewModel> Playlists { get; set; }
}