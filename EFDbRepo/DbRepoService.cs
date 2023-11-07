using EHR.Api.Dtos;
using EHR.AppService.Interfaces;
using EHR.Core.Interfaces;
using EHR.Core.Models;

namespace EFDbRepo
{
    public class DbRepoService : IDbRepo
    {
        private readonly AppDbContext _appDbContext;
        public DbRepoService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Claim> GetClaimStatus(string ClaimID)
        {
            var claim = await _appDbContext.Claims.FindAsync(ClaimID);
            if (claim != null)
            {
                return claim;
            }
            return null;
        }

        public Task<PolicyHolder> Create(PolicyHolder holder)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Submit(Claim claim)
        {
             _appDbContext.Claims.Add(claim);
            return await _appDbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateClaim(Claim claimstatus)
        {
            _appDbContext.Claims.Attach(claimstatus);
            _appDbContext.Entry(claimstatus).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return await _appDbContext.SaveChangesAsync();
        }
    }
}
