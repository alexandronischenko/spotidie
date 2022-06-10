using Spotidie.DAL.Entities;

namespace BLL.ModelsDTO;

public class DTOMapper
{
    public static UserDTO MapUser(MainUser user)
    {
        return new UserDTO
        {
            UserId = user.MainUserId,
            UserEmail = user.MainUserEmail,
            UserName = user.MainUserName,
            UserIsPremium = user.MainUserIsPremium,
            UserIsAdmin = user.MainUserIsAdmin,
            UserAvatar = user.MainUserAvatar
        };
    }

    public static PlaylistDTO MapPlaylist(Playlist playlist)
    {
        var playlistDtos = new List<PlaylistDTO>();

        // if (playlist.Track != null)
        // {
        //     foreach (var track in playlist.Track)
        //     {
        //         playlistDtos.Add(MapTrack(track));
        //     }
        // }
        
        return new PlaylistDTO
        {
            PlaylistId = playlist.PlaylistId,
            PlaylistAvatar = playlist.PlaylistAvatar,
            PlaylistName = playlist.PlaylistName,
            PlaylistForeignKey = playlist.PlaylistForeignKey,
            // User = MapUser(playlist.MainUser),
        };
    }

    public static IEnumerable<PlaylistDTO> MapPlaylists(IEnumerable<Playlist> playlists)
    {
        var playlistsDTO = new List<PlaylistDTO>();
        foreach (var playlist in playlists)
        {
            playlistsDTO.Add(MapPlaylist(playlist));
        }

        return playlistsDTO;
    }

    public static TrackDTO MapTrack(Track track)
    {
        return new TrackDTO
        {
            TrackId = track.TrackId,
            TrackName = track.TrackName,
            TrackDuration = track.TrackDuration,
            TrackData = track.TrackData,
            TrackDataByte = track.TrackDataByte,
            TrackAvatar = track.TrackAvatar,
            TrackForeignKey = track.TrackForeignKey
        };
    }

    public static AuthorDTO MapAuthor(Author author)
    {
        var tracksDTO = new List<TrackDTO>();
        
        // TODO
        // foreach (var track in author.Tracks)
        // {
        //     tracksDTO.Add(MapTrack(track));
        // }

        return new AuthorDTO
        {
            AuthorId = author.AuthorId,
            AuthorName = author.AuthorName,
            AuthorAvatar = author.AuthorAvatar,
            AuthorForeignKey = author.AuthorForeignKey
        };
    }
    
    public static IEnumerable<AuthorDTO> MapAuthors(IEnumerable<Author> authors)
    {
        // TODO
        var authorDTOs = new List<AuthorDTO>();
        foreach (var author in authors)
        {
            authorDTOs.Add(MapAuthor(author));
        }

        return authorDTOs;
    }
}