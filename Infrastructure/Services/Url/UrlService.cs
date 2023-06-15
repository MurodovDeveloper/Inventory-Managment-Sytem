using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Url
{

    public class UrlService : IUrlService
    {
        //public string GenerateReturnUrl(string path, HttpContext httpContext)
        //{
        //    var host = $"{httpContext.Request.Scheme}://{httpContext.Request.Host}";
        //    return $"{host}/{path}";
        //}

        public string GenerateReturnUrl(string path, HttpContext httpContext)
        {
            var host = $"{httpContext.Request.Scheme}://{httpContext.Request.Host}";
            return $"{host}/{path}";
        }
    }
}
