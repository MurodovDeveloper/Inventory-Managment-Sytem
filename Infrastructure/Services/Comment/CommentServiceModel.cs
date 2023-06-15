using Infrastructure.Services.UserServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Comment
{
    public class CommentServiceModel
    {
        public int CommentId { get; set; }

        public string Content { get; set; }

        public DateTime DatePosted { get; set; }

        public UserServiceModel Author { get; set; }

        public int PostId { get; set; }

        public ICollection<UserServiceModel> TaggedFriends { get; set; }
    }
}
