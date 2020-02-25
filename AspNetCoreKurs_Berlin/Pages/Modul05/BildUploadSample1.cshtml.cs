using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreKurs_Berlin
{
    public class BildUploadSample1Model : PageModel
    {
        public void OnGet()
        {

        }

        public void OnPost(IFormFile datei)
        {
            FileInfo fileInfo = new FileInfo(datei.FileName);
            var pfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\" + fileInfo.Name;

            using (var fs = new FileStream(pfad, FileMode.Create))
            {
                datei.CopyTo(fs);
            }
        }
    }
}