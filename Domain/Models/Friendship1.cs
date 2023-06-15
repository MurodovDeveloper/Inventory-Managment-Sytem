using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Friendship1
    {
        public string RequesterId { get; set; }

        public string AddresseeId { get; set; }

        public Status Status { get; set; }

        public User Addressee { get; set; }

        public User Requester { get; set; }
    }

    public enum Status
    {
        Pending = 0,
        Accepted = 1
    }
}
