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
    public class IndexModel : PageModel
    {
        private readonly waterMeter.Data.waterMeterContext _context;

        public IndexModel(waterMeter.Data.waterMeterContext context)
        {
            _context = context;
        }

        public IList<MetersData> MetersData { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.MetersData != null)
            {
                MetersData = await _context.MetersData.ToListAsync();
            }
        }
    }
}
