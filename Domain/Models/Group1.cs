using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
namespace Domain.Models
{
    public class Group1
    {
        public Group1()
        {
            this.Members = new HashSet<UserInGroup>();
            this.Posts = new HashSet<Posts>();
        }

        public int GroupId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<UserInGroup> Members { get; set; }
        public ICollection<Posts> Posts { get; set; }
    }
}
