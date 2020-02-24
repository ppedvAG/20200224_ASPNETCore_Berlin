using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCoreKurs_Berlin.Pages.Modul03
{
    public class Calc1Model : PageModel
    {
        public int Ergebnis { get; set; }
        public void OnGet()
        {
            Ergebnis = 0;
        }

        public void OnGetHannes()
        {
            Ergebnis = 42;
        }

        public void OnPost()
        
        {
            try

            {
                int eins = int.Parse(Request.Form["eins"].FirstOrDefault());
                int zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());

                Ergebnis = eins + zwei;
            }
            catch(Exception ex)
            {
                
            }
            
        }

    }
}
