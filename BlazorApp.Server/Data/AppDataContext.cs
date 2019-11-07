using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions options )
            :base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
