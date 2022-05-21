namespace BLL.Interfaces;

public interface IRoleService
{

    Task UpdatePremiumRole(string id, bool status);

    Task UpdateAdminRole(string id, bool status);
}