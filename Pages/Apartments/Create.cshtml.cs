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

namespace waterMeter.Pages.Apartments
{
    public class CreateModel : MeterPageModel
    {
        private readonly Data.waterMeterContext _context;

        public CreateModel(Data.waterMeterContext context)
        {
            _context = context;
        }
        public string Message { get; private set; } = "";
        public IActionResult OnGet()
        {
            MetersDropDownList(_context);
            Message = "<Улица>/<Дом>/<Номер квартиры>";
            return Page();
        }

        [BindProperty]
        public Apartment Apartment { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            _context.Attach(Apartment);
            _context.Apartment.Add(Apartment);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");

        }
    }
}