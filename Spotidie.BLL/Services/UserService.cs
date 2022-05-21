using System.ComponentModel.DataAnnotations;
using BLL.Interfaces;
using BLL.ModelsDTO;
using Spotidie.DAL.Interfaces;

namespace BLL.Services;

public class UserService : IUserService
{
    public UserService(IUnitOfWork db)
    {
        Db = db;
    }

    private IUnitOfWork Db { get; set; }

    public async Task<UserDTO> GetUser(string id)
    {
        if (id is null)
            throw new ValidationException("Id is null");
        
        var user = Db.MainUsers.Get(Guid.Parse(id));

        if (user is null)
            throw new ValidationException("User not found");

        return DTOMapper.MapUser(user);
    }

    public async Task<IEnumerable<UserDTO>> GetUsers()
    {
        var users = Db.MainUsers.GetAll();
        if (users is null)
            throw new ValidationException("Users not found");

        var usersDTO = new List<UserDTO>();
        foreach (var user in users)
        {
            usersDTO.Add(DTOMapper.MapUser(user));
        }


        return usersDTO;
    }
}