using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using waterMeter.Models;

namespace waterMeter.Pages.Meters
{
    public class DetailsModel : PageModel
    {
        private readonly Data.waterMeterContext _context;

        public DetailsModel(Data.waterMeterContext context)
        {
            _context = context;
        }

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
    }
}
