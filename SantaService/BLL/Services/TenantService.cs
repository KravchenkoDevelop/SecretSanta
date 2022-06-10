using DAL.Models;

namespace BLL;

public partial class TenantService : ITenantService
{
    public Task<TenantModel> CreateNewTenant(Tenant newTenant)
    {
        throw new NotImplementedException();
    }
}