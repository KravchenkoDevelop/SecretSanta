using DAL.Models;
using DM.Models;

namespace BLL
{
    public interface ITenantService
    {
        public Task<TenantModel> CreateNewTenant(Tenant newTenant);
    }
}