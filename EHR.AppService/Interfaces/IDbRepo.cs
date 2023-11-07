
using EHR.Core.Models;

namespace EHR.AppService.Interfaces
{
    public interface IDbRepo
    {
        Task<PolicyHolder> Create(PolicyHolder holder);
        Task<int> Submit(Claim claim);
        Task<int> UpdateClaim(Claim claimstatus);
        Task<Claim> GetClaimStatus(string CLaimID);
    }
}
