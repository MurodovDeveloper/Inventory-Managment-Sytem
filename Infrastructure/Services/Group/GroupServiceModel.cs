using Infrastructure.Services.UserServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Group
{
    public class GroupServiceModel
    {
        public GroupServiceModel()
        {
            this.Members = new List<UserServiceModel>();
        }

        public int GroupId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string AdminId { get; set; }

        public ICollection<UserServiceModel> Members { get; set; }
    }
}
