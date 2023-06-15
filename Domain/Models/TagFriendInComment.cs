using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class TagFriendInComment
    {
        public int Id { get; set; }

        /// <summary>
        /// User who tag a friend
        /// </summary>
        public string TaggerId { get; set; }
        public User Tagger { get; set; }

        /// <summary>
        /// User who is tagged by some of its friends
        /// </summary>
        public string TaggedId { get; set; }
        public User Tagged { get; set; }

        public int CommentId { get; set; }
        public Comments Comment { get; set; }
    }
}
