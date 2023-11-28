using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
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
        public IList<Apartment> Apartments { get; set; }
        public IList<MetersData> MetersDatas { get; set; }
        public Dictionary<int, object> ActualDatas = new Dictionary<int, object>();

        public async Task OnGetAsync()
        {
            if (_context.Apartment == null)
            {
                return;
            }

            Meters = await _context.Meter.ToListAsync();
            Apartments = await _context.Apartment.ToListAsync();
            MetersDatas = await _context.MetersData.ToListAsync();
            CompleteActualData();
        }

        public void CompleteActualData()
        {
            var GroupedData = MetersDatas.GroupBy(s => s.Meter).ToList();

            foreach (var dat in  GroupedData)
            {
                var key = dat.Last().Meter.Id;
                var val = dat.Last().Value.ToString();

                ActualDatas.Add(key, val);
            }
        }
    }
}
