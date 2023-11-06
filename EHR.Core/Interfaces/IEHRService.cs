using EHR.Api.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHR.Core.Interfaces
{
    public interface IEHRService
    {
        Task<PolicyHolder> Create(PolicyHolder holder);
        Task<PolicyHolder> Update(PolicyHolder holder);
    }
}
