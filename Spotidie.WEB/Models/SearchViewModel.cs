namespace Spotidie.Models;

public class SearchViewModel
{
    public List<PlaylistViewModel> Playlists = new List<PlaylistViewModel>();
    public List<AuthorViewModel> Authors = new List<AuthorViewModel>();
    public List<TrackViewModel> Tracks = new List<TrackViewModel>();
}