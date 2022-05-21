using BLL.Interfaces;
using Spotidie.DAL.Interfaces;

namespace BLL.Services;

public class RoleService : IRoleService
{
    
    public RoleService(IUnitOfWork db)
    {
        Db = db;
    }

    private IUnitOfWork Db { get; set; }
    
    public async Task UpdatePremiumRole(string id, bool status)
    {
        if (id == null )
            throw new Exception("Id is null");

        var user = Db.MainUsers.Get(Guid.Parse(id));

        if (user == null)
            throw new Exception("User not found");

        if (user.MainUserIsPremium == status)
        {
            throw new Exception("Equals are the same");
        }

        user.MainUserIsPremium = status;
        Db.MainUsers.Update(user);
    }

    public async Task UpdateAdminRole(string id, bool status)
    {
        if (id == null )
            throw new Exception("Id is null");

        var user = Db.MainUsers.Get(Guid.Parse(id));

        if (user == null)
            throw new Exception("User not found");

        if (user.MainUserIsAdmin == status)
        {
            throw new Exception("Equals are the same");
        }

        user.MainUserIsAdmin = status;
        Db.MainUsers.Update(user);
    }
}