using DAL.Models;
using SecretSantaGenerator.DM.Models;
using System.Threading.Tasks;

namespace BLL.Abstracts;

public interface ITenantService
{
    public Task<TenantModel> CreateNewTenant(Tenant newTenant);



}