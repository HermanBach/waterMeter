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
    public class IndexModel : PageModel
    {
        private readonly waterMeter.Data.waterMeterContext _context;

        public IndexModel(waterMeter.Data.waterMeterContext context)
        {
            _context = context;
        }

        public IList<Apartment> Apartment { get;set; } = default!;
        public IList<string> Houses = new List<string>();

        public async Task OnGetAsync()
        {
            if (_context.Apartment != null)
            {
                Apartment = await _context.Apartment.ToListAsync();
            }
        }

        public void CompleteHouses()
        {
            foreach (var apartment in Apartment)
            {
                Houses.Add(apartment.Name);
            }

        }
    }
}
