using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreKurs_Berlin
{
    [ResponseCache (Duration = 30,  VaryByHeader = "User-Agent")]
    public class ResponseCacheSampleModel : PageModel
    {

        // https://docs.microsoft.com/de-de/aspnet/core/performance/caching/response?view=aspnetcore-3.1
        // https://blog.ppedv.de/post/Response-Caching-funktioniert-nicht-mit-ASPNET-core
        public void OnGet()
        {

        }
    }
}