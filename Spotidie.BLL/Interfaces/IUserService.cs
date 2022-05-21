using BLL.ModelsDTO;

namespace BLL.Interfaces;

public interface IUserService
{

    Task<UserDTO> GetUser(string id);

    Task<IEnumerable<UserDTO>> GetUsers();
}