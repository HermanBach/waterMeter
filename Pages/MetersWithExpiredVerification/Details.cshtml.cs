using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using waterMeter.Data;
using waterMeter.Models;

namespace waterMeter.Pages.MetersWithExpiredVerification
{
    public class DetailsModel : PageModel
    {
        private readonly waterMeter.Data.waterMeterContext _context;

        public DetailsModel(waterMeter.Data.waterMeterContext context)
        {
            _context = context;
        }

      public Apartment Apartment { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Apartment == null)
            {
                return NotFound();
            }

            var apartment = await _context.Apartment.FirstOrDefaultAsync(m => m.Id == id);
            if (apartment == null)
            {
                return NotFound();
            }
            else 
            {
                Apartment = apartment;
            }
            return Page();
        }
    }
}
