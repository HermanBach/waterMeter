using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using waterMeter.Models;

namespace waterMeter.Pages.Apartments
{
    public class IndexModel : PageModel
    {
        private readonly Data.waterMeterContext _context;

        public IndexModel(Data.waterMeterContext context)
        {
            _context = context;
        }

        public IList<Meter> Meters { get; set; }
        public IList<Apartment> Apartments { get;set; }
        public IList<MetersData> MetersDatas { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Apartment == null)
            {
                return;
            }

            Meters = await _context.Meter.ToListAsync();
            Apartments = await _context.Apartment.ToListAsync();
            MetersDatas = await _context.MetersData.ToListAsync();
        }
    }
}
