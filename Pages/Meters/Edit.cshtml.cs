using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using waterMeter.Models;

namespace waterMeter.Pages.Meters
{
    public class EditModel : PageModel
    {
        private readonly Data.waterMeterContext _context;

        public EditModel(Data.waterMeterContext context)
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

            var meter =  await _context.Meter.FirstOrDefaultAsync(m => m.Id == id);
            if (meter == null)
            {
                return NotFound();
            }
            Meter = meter;
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

            _context.Attach(Meter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MeterExists(Meter.Id))
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

        private bool MeterExists(int id)
        {
          return (_context.Meter?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
