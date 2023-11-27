using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using waterMeter.Models;

namespace waterMeter.Pages.Apartments
{
    public class DetailsModel : PageModel
    {
        private readonly Data.waterMeterContext _context;

        public DetailsModel(Data.waterMeterContext context)
        {
            _context = context;
        }
        
        public List<Meter> Meters { get; set; }
        public Apartment Apartment { get; set; } = default!;
        public List<MetersData> MetersDatas { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Meters = await _context.Meter.ToListAsync();

            if (id == null || _context.Apartment == null)
            {
                return NotFound();
            }

            var apartment = await _context.Apartment.FirstOrDefaultAsync(m => m.Id == id);
            if (apartment == null)
            {
                return NotFound();
            }

            Apartment = apartment;
            MetersDatas = await _context.MetersData.Where(s => s.Meter.Id == Apartment.Meter.Id)
                .ToListAsync();

            return Page();
        }
    }
}
