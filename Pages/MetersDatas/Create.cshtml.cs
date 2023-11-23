using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using waterMeter.Data;
using waterMeter.Models;

namespace waterMeter.Pages.MetersDatas
{
    public class CreateModel : PageModel
    {
        private readonly waterMeter.Data.waterMeterContext _context;

        public CreateModel(waterMeter.Data.waterMeterContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public MetersData MetersData { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.MetersData == null || MetersData == null)
            {
                return Page();
            }

            _context.MetersData.Add(MetersData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
