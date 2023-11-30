using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using waterMeter.Models;

namespace waterMeter.Pages.Meters
{
    public class DeleteModel : PageModel
    {
        private readonly Data.waterMeterContext _context;

        public DeleteModel(Data.waterMeterContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Meter Meter { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Meter == null)
            {
                return NotFound();
            }

            var meter = await _context.Meter.FirstOrDefaultAsync(m => m.Id == id);

            if (meter == null)
            {
                return NotFound();
            }
            else 
            {
                Meter = meter;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Meter == null)
            {
                return NotFound();
            }
            var meter = await _context.Meter.FindAsync(id);

            if (meter != null)
            {
                Meter = meter;
                _context.Meter.Remove(Meter);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
