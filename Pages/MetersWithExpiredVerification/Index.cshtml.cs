using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using waterMeter.Data;
using waterMeter.Models;

namespace waterMeter.Pages.MetersWithExpiredVerification
{
    public class IndexModel : PageModel
    {
        private readonly Data.waterMeterContext _context;

        public IndexModel(Data.waterMeterContext context)
        {
            _context = context;
        }

        public IList<Meter> Meters { get; set; }
        public IList<Apartment> Apartment { get; set; }
        public IList<string> DistHouses = new List<string>();
        public Dictionary<string, string> ExperiedMeters = new Dictionary<string, string>();
        public async Task OnGetAsync()
        {

            if (_context.Apartment == null)
            {
                return;
            }

            Meters = await _context.Meter.ToListAsync();
            Apartment = await _context.Apartment.ToListAsync();

            distAdress();
        }

        public IList<string> GetHousesAdres()
        {
            IList<string> Houses = new List<string>();
            string addr;
            foreach (var apartment in Apartment)
            {

                string[] house = apartment.Name
                            .Replace("/", " ")
                            .Replace(">", "")
                            .Split("<");
                addr = String.Concat(house[1], house[2]);
                Houses.Add(addr);
                DateTime dateTime = DateTime.Now;
                if (apartment.Meter.NextVerification < dateTime)
                {
                    ExperiedDictinary(addr, apartment.Meter.FactoryNumber);
                }

                if (!ExperiedMeters.ContainsKey(addr))
                {
                    ExperiedMeters.Add(addr, "");
                }
            }
            return Houses;
        }
        public void distAdress()
        {
            DistHouses = GetHousesAdres().Distinct().ToList();
        }

        public void ExperiedDictinary(string key, string val)
        {
            if (ExperiedMeters.ContainsKey(key))
            {
                ExperiedMeters[key] = String.Concat(ExperiedMeters[key], " ", val);
            } else
            {
                ExperiedMeters.Add(key, val);
            }

        }

    }
}
