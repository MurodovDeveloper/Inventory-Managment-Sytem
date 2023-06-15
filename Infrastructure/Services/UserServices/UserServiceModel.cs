using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.UserServices
{
    public class UserServiceModel
    {
        public string Id { get; set; }

        public string FullName { get; set; }

        public string UserName { get; set; }

        public string Country { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
