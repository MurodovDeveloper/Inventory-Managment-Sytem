using Infrastructure.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Post
{
    public interface IPostService 
    {
        Task AddPost(PostServiceModel serviceModel);

        Task EditPost(PostServiceModel serviceModel);

        Task DeletePost(int id);

        Task<PostServiceModel> GetPost(int id);

        Task<ICollection<PostServiceModel>> GetPostsByUserIdAsync(string userId);

        Task<ICollection<PostServiceModel>> GetPostsByGroupIdAsync(int groupId);

        Task<int?> GetGroupIdOfPost(int id);
    }
}
