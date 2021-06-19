using Microsoft.EntityFrameworkCore;
using PolutionMapAPI.Models;

namespace PolutionMapAPI.Data
{
    public class MeasurementContext : DbContext
    {
        public MeasurementContext(DbContextOptions<MeasurementContext> options) : base(options)
        {
        }
        
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<MeasurementProperties> MeasurementProperties { get; set; }
    }
}
