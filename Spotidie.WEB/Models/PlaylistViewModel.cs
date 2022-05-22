namespace Spotidie.Models;

public class PlaylistViewModel
{
    public Guid PlaylistId { get; set; }
    public string PlaylistName { get; set; }       
    public string PlaylistAvatar { get; set; }
    public UserViewModel User { get; set; }
    public List<TrackViewModel> Tracks { get; set; }
}