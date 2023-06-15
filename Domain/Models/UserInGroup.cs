using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserInGroup
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public int GroupId { get; set; }
        public Group1 Group { get; set; }
        public bool Admin { get; set; } = false;
    }
}
