﻿using EHR.Core.Models;

namespace EHR.Core.Interfaces
{
    public interface IEHRService
    {
        Task<PolicyHolder> Create(PolicyHolder holder);
        Task<int> Submit(Claim claim);
        Task<int> UpdateClaim(Claim claimstatus);
        Task<Claim> ClaimStatus(string CLaimID);
    }
}
