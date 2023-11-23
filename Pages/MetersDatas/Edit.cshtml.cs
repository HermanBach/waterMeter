using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using waterMeter.Data;
using waterMeter.Models;

namespace waterMeter.Pages.MetersDatas
{
    public class EditModel : PageModel
    {
        private readonly waterMeter.Data.waterMeterContext _context;

        public EditModel(waterMeter.Data.waterMeterContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MetersData MetersData { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.MetersData == null)
            {
                return NotFound();
            }

            var metersdata =  await _context.MetersData.FirstOrDefaultAsync(m => m.Id == id);
            if (metersdata == null)
            {
                return NotFound();
            }
            MetersData = metersdata;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MetersData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MetersDataExists(MetersData.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MetersDataExists(int id)
        {
          return (_context.MetersData?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
