using BAL.ModelsDTO;

namespace BAL.Interfaces;

public interface IUserService
{

    Task<UserDTO> GetUser(string id);

    Task<IEnumerable<UserDTO>> GetUsers();
}