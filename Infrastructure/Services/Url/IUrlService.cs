using Infrastructure.Services.Common;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Url
{
    public interface IUrlService
    {
        string GenerateReturnUrl(string path, HttpContext httpContext);
    }
}
