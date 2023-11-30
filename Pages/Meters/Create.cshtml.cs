using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using waterMeter.Models;

namespace waterMeter.Pages.Meters
{
    public class CreateModel : PageModel
    {
        private readonly Data.waterMeterContext _context;

        public CreateModel(Data.waterMeterContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Meter Meter { get; set; } = default!;
        
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Meter == null || Meter == null)
            {
                return Page();
            }

            _context.Meter.Add(Meter);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
