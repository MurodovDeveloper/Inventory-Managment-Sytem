using Infrastructure.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.UserServices
{
    public interface IUserService 
    {
        Task<UserServiceModel> GetUserByIdAsync(string userId);

        Task<string> GetUserIdByNameAsync(string name);

        Task<UserServiceModel> GetUserByNameAsync(string name);
    }
}
