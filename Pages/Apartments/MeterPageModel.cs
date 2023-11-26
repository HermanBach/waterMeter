using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using waterMeter.Data;
using waterMeter.Models;

namespace waterMeter.Pages.Apartments
{
    public class MeterPageModel : PageModel
    {
        public SelectList MetersList { get; set; }

        public void MetersDropDownList(waterMeterContext _context, object selectMeter = null)
        {
            var metersQuery = from d in _context.Meter
                              orderby d.Id
                              select d;

            MetersList = new SelectList(metersQuery.AsNoTracking(),
                nameof(Meter.Id),
                nameof(Meter.FactoryNumber),
                selectMeter);

        }
    }
}
