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

        public DbSet<Apartment> Apartment { get; set; } = default!;

        public DbSet<Meter> Meter { get; set; } = default!;

        public DbSet<MetersData> MetersData { get; set; } = default!;

        public DbSet<MeterReplacementHistory> MeterReplacementHistory { get; set; } = default!;

    }
}
