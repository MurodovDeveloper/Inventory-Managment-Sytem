using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Identity;

namespace Domain.Models
{
    [Table("Users")]
    public class User : IdentityUser
    {
        public User()
        {
            this.Posts = new HashSet<Posts>();
            this.Comments = new HashSet<Comments>();
            this.FriendshipAddressee = new HashSet<Friendship1>();
            this.FriendshipRequester = new HashSet<Friendship1>();
            this.Groups = new HashSet<UserInGroup>();
            this.Images = new HashSet<Imager>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{this.FirstName} {this.LastName}";
        public string City { get; set; }
        public string Country { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }
        [DataType(DataType.MultilineText)]
        public string Bio { get; set; }
        public string Locale { get; set; } = "en-GB";
        public ICollection<Posts> Posts { get; set; }
        public ICollection<Comments> Comments { get; set; }
        public ICollection<Friendship1> FriendshipAddressee { get; set; }
        public ICollection<Friendship1> FriendshipRequester { get; set; }
        public ICollection<UserInGroup> Groups { get; set; }
        public ICollection<TagFriendInPost> TaggerInPosts { get; set; }
        public ICollection<TagFriendInPost> TaggedInPosts { get; set; }
        public ICollection<TagFriendInComment> TaggerInComments { get; set; }
        public ICollection<TagFriendInComment> TaggedInComments { get; set; }
        public ICollection<Imager> Images { get; set; }
        public int AvatarId { get; set; }
        public Avatar Avatar { get; set; }
        public string UserName { get; set; }
    }

    public enum Gender
    {
        male = 0,
        female = 1
    }
}


