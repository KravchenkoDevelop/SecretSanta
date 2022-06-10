using BLL.Abstracts;
using DAL.Models;
using DM.Models;

namespace BLL;

public partial class TenantService : ITenantService
{
    public Task<TenantModel> CreateNewTenant(Tenant newTenant)
    {
        throw new NotImplementedException();
    }
}