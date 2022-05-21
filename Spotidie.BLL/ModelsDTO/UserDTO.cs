namespace BLL.ModelsDTO;

public class UserDTO
{
    public Guid UserId { get; set; }
    public string UserEmail { get; set; }
    public string UserName { get; set; }
    public bool UserIsPremium { get; set; }
    public bool UserIsAdmin { get; set; }
    public string UserAvatar { get; set; }
}