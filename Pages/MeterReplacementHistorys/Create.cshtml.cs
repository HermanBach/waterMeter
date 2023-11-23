using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using waterMeter.Data;
using waterMeter.Models;

namespace waterMeter.Pages.MeterReplacementHistorys
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
        public MeterReplacementHistory MeterReplacementHistory { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.MeterReplacementHistory == null || MeterReplacementHistory == null)
            {
                return Page();
            }

            _context.MeterReplacementHistory.Add(MeterReplacementHistory);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
