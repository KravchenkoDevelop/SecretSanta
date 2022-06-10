using BLL.Abstracts;
using DAL.Models;

namespace BLL.Services;

public partial class TenantService : ITenantService
{
    public Task<TenantModel> CreateNewTenant(Tenant newTenant)
    {
        throw new NotImplementedException();
    }
}