using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{

    public class Avatar
    {
        public int Id { get; set; }
        public byte[] AvatarData { get; set; }
        public string UploaderId { get; set; }
        public User Uploader { get; set; }
    }
}
