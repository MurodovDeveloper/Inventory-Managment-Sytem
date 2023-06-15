using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Stream
{
    public class StreamService : IStreamService
    {
        public async Task<MemoryStream> CopyFileToMemoryStreamAsync(IFormFile file)
        {
            using (var ms = new MemoryStream())
            {
                await file.CopyToAsync(ms);
                return ms;
            }
        }
    }
}
