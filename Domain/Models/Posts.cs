using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Posts
    {
        public Posts()
        {
            this.Comments = new HashSet<Comments>();
            this.TaggedUsers = new HashSet<TagFriendInPost>();
        }

        public int PostId { get; set; }
        public DateTime DatePosted { get; set; }
        public string Content { get; set; }
        public string AuthorId { get; set; }
        public User Author { get; set; }
        public int? GroupId { get; set; }
        public Group1 Group { get; set; }
        public ICollection<Comments> Comments { get; set; }
        public ICollection<TagFriendInPost> TaggedUsers { get; set; }
    }
}
