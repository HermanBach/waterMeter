using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using waterMeter.Data;
using waterMeter.Models;

namespace waterMeter.Pages.MeterReplacementHistorys
{
    public class EditModel : PageModel
    {
        private readonly waterMeter.Data.waterMeterContext _context;

        public EditModel(waterMeter.Data.waterMeterContext context)
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

            var meterreplacementhistory =  await _context.MeterReplacementHistory.FirstOrDefaultAsync(m => m.Id == id);
            if (meterreplacementhistory == null)
            {
                return NotFound();
            }
            MeterReplacementHistory = meterreplacementhistory;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MeterReplacementHistory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeterReplacementHistoryExists(MeterReplacementHistory.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MeterReplacementHistoryExists(int id)
        {
          return (_context.MeterReplacementHistory?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
