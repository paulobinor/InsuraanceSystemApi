using EHR.AppService.Interfaces;
using EHR.Core.Interfaces;
using EHR.Core.Models;

namespace EHR.AppService
{
    public class EHRService : IEHRService
    {
        private readonly IDbRepo _dbRepo;

        public EHRService(IDbRepo dbRepo)
        {
            _dbRepo = dbRepo;
        }

        public Task<Claim> ClaimStatus(string CLaimID)
        {
            return _dbRepo.GetClaimStatus(CLaimID);
        }

        public Task<PolicyHolder> Create(PolicyHolder holder)
        {
            return _dbRepo.Create(holder);
        }

        public Task<int> Submit(Claim claim)
        {
           return _dbRepo.Submit(claim);
        }

        public Task<int> UpdateClaim(Claim claimstatus)
        {
          return  _dbRepo.UpdateClaim(claimstatus);
        }
    }
}