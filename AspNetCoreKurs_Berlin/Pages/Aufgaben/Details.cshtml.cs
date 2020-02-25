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
    public class DetailsModel : PageModel
    {
        private readonly AspNetCoreKurs_Berlin.Data.AufgabenContext _context;

        public DetailsModel(AspNetCoreKurs_Berlin.Data.AufgabenContext context)
        {
            _context = context;
        }

        public Aufgaben Aufgaben { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Aufgaben = await _context.Aufgaben.FirstOrDefaultAsync(m => m.ID == id);

            if (Aufgaben == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
