using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Api.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions options )
            :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
