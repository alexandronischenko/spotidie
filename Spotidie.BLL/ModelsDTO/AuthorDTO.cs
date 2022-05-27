namespace BLL.ModelsDTO;

public class AuthorDTO
{
    public Guid AuthorId { get; set; }
    public string AuthorName { get; set; }
    public string AuthorAvatar { get; set; }
    
    public int AuthorForeignKey { get; set; }
}