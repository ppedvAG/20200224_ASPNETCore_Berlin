using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspNetCoreKurs_Berlin.Data;

namespace AspNetCoreKurs_Berlin
{
    public class CreateModel : PageModel
    {
        private readonly AspNetCoreKurs_Berlin.Data.AufgabenContext _context;

        public CreateModel(AspNetCoreKurs_Berlin.Data.AufgabenContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Aufgaben Aufgaben { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Aufgaben.Add(Aufgaben);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
