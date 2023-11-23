using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using waterMeter.Data;
using waterMeter.Models;

namespace waterMeter.Pages.MetersDatas
{
    public class DetailsModel : PageModel
    {
        private readonly waterMeter.Data.waterMeterContext _context;

        public DetailsModel(waterMeter.Data.waterMeterContext context)
        {
            _context = context;
        }

      public MetersData MetersData { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.MetersData == null)
            {
                return NotFound();
            }

            var metersdata = await _context.MetersData.FirstOrDefaultAsync(m => m.Id == id);
            if (metersdata == null)
            {
                return NotFound();
            }
            else 
            {
                MetersData = metersdata;
            }
            return Page();
        }
    }
}
