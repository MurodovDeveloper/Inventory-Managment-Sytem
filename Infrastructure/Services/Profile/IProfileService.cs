using Infrastructure.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Profile
{
    public interface IProfileService
    {
        Task<ProfileServiceModel> GetProfileAsync(string userId);
    }
}
