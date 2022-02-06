using Microsoft.EntityFrameworkCore;
using NetCoreMVCWebsite.Models;

namespace NetCoreMVCWebsite.Data
{
    public class GalleryDBContext : DbContext
    {
        public GalleryDBContext(DbContextOptions<GalleryDBContext> options)
            : base(options)
        {

        }

        public DbSet<GalleryModel> Gallery { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("GalleryConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}