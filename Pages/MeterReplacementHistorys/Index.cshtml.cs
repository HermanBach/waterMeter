using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using waterMeter.Models;

namespace waterMeter.Pages.MeterReplacementHistorys
{
    public class IndexModel : PageModel
    {
        private readonly Data.waterMeterContext _context;

        public IndexModel(Data.waterMeterContext context)
        {
            _context = context;
        }

        public IList<MeterReplacementHistory> MeterReplacementHistory { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.MeterReplacementHistory != null)
            {
                MeterReplacementHistory = await _context.MeterReplacementHistory.ToListAsync();
            }
        }
    }
}
