using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
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
        public Dictionary<string, string> Address = new Dictionary<string, string>();

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
            CompleteApartmentsAddress();
        }

        public void CompleteActualData()
        {
            var GroupedData = MetersDatas.GroupBy(s => s.Meter).ToList();

            foreach (var dat in GroupedData)
            {
                var key = dat.Last().Meter.Id;
                var val = dat.Last().Value;

                ActualDatas.Add(key, val);
            }

            foreach (var meter in Meters)
            {
                if (!ActualDatas.ContainsKey(meter.Id))
                {
                    ActualDatas.Add(meter.Id, null);
                }
            }
        }

        public string GetAddress(string fullAddress)
        {
            string[] house = fullAddress
            .Replace("/", " ")
            .Replace(">", "")
            .Split("<");
            return String.Concat("ул. ", house[1], "д. ", house[2], "кв. ", house[3]);
        }

        public void CompleteApartmentsAddress()
        {
            foreach (var apart in Apartments)
            {
                Address.Add(apart.Name, GetAddress(apart.Name));
            }
        }

    }
}
