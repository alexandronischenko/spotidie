namespace BAL.ModelsDTO;

public class AuthorDTO
{
    public Guid AuthorId { get; set; }
    public string AuthorName { get; set; }
    public byte[] AuthorAvatar { get; set; }
    public List<TrackDTO> Tracks { get; set; }
}