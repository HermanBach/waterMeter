using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using waterMeter.Models;

namespace waterMeter.Pages.Meters
{
    public class IndexModel : PageModel
    {
        private readonly Data.waterMeterContext _context;

        public IndexModel(Data.waterMeterContext context)
        {
            _context = context;
        }

        public IList<Meter> Meter { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Meter != null)
            {
                Meter = await _context.Meter.ToListAsync();
            }
        }
    }
}
