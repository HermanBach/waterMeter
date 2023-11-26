using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using waterMeter.Models;

namespace waterMeter.Pages.Apartments
{
    public class IndexModel : PageModel
    {
        private readonly waterMeter.Data.waterMeterContext _context;

        public IndexModel(waterMeter.Data.waterMeterContext context)
        {
            _context = context;
        }

        public IList<Apartment> Apartment { get;set; }

        public async Task OnGetAsync()
        {
            if (_context.Apartment != null)
            {
                Apartment = await _context.Apartment.ToListAsync();
            }
        }
    }
}
