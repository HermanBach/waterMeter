using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using waterMeter.Models;

namespace waterMeter.Data
{
    public class waterMeterContext : DbContext
    {
        public waterMeterContext (DbContextOptions<waterMeterContext> options)
            : base(options)
        {
        }

        public DbSet<waterMeter.Models.Apartment> Apartment { get; set; } = default!;

        public DbSet<waterMeter.Models.Meter> Meter { get; set; } = default!;

        public DbSet<waterMeter.Models.MetersData> MetersData { get; set; } = default!;

        public DbSet<waterMeter.Models.MeterReplacementHistory> MeterReplacementHistory { get; set; } = default!;

    }
}
