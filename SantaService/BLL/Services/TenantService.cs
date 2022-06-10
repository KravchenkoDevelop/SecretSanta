using BLL.Abstracts;
using DAL.Models;
using SecretSantaGenerator.DM.Models;
using System.Threading.Tasks;

namespace BLL.Services;

public partial class TenantService : ITenantService
{
    public Task<TenantModel> CreateNewTenant(Tenant newTenant)
    {
        throw new NotImplementedException();
    }
}