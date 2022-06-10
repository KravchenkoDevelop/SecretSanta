using DAL.Models;
using DM.Models;

namespace BLL.Abstracts;

public interface ITenantService
{
    public Task<TenantModel> CreateNewTenant(Tenant newTenant);

}