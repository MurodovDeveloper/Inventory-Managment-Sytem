using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Image
{
    public class AvatarServiceModel
    {
        public int AvatarId { get; set; }
        public byte[] AvatarData { get; set; }
        public string UploaderId { get; set; }
    }
}
