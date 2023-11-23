using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using waterMeter.Data;
using waterMeter.Models;

namespace waterMeter.Pages.MeterReplacementHistorys
{
    public class DeleteModel : PageModel
    {
        private readonly waterMeter.Data.waterMeterContext _context;

        public DeleteModel(waterMeter.Data.waterMeterContext context)
        {
            _context = context;
        }

        [BindProperty]
      public MeterReplacementHistory MeterReplacementHistory { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.MeterReplacementHistory == null)
            {
                return NotFound();
            }

            var meterreplacementhistory = await _context.MeterReplacementHistory.FirstOrDefaultAsync(m => m.Id == id);

            if (meterreplacementhistory == null)
            {
                return NotFound();
            }
            else 
            {
                MeterReplacementHistory = meterreplacementhistory;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.MeterReplacementHistory == null)
            {
                return NotFound();
            }
            var meterreplacementhistory = await _context.MeterReplacementHistory.FindAsync(id);

            if (meterreplacementhistory != null)
            {
                MeterReplacementHistory = meterreplacementhistory;
                _context.MeterReplacementHistory.Remove(MeterReplacementHistory);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
