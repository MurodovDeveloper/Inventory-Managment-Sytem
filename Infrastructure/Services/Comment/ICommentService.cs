using Infrastructure.Services.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Comment
{
    public interface ICommentService : IService
    {
        Task AddComment(CommentServiceModel commentServiceModel);

        Task EditComment(CommentServiceModel serviceModel);

        Task DeleteComment(int id);

        Task<CommentServiceModel> GetComment(int id);

        Task<ICollection<CommentServiceModel>> GetCommentsByPostIdAsync(int postId);
    }
}
