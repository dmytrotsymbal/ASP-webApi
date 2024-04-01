using ASP_webapi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_webapi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Hero> Heroes { get; set; } // name of table
    }
}
