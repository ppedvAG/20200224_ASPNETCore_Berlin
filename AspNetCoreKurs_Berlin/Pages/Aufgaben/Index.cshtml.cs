using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspNetCoreKurs_Berlin.Data;

namespace AspNetCoreKurs_Berlin
{
    public class IndexModel : PageModel
    {
        private readonly AspNetCoreKurs_Berlin.Data.AufgabenContext _context;

        public IndexModel(AspNetCoreKurs_Berlin.Data.AufgabenContext context)
        {
            _context = context;
        }

        public IList<Aufgaben> Aufgaben { get;set; }

        public async Task OnGetAsync()
        {
            Aufgaben = await _context.Aufgaben.ToListAsync();
        }
    }
}
