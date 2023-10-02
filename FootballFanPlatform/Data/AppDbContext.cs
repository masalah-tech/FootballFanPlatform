using Microsoft.EntityFrameworkCore;

namespace FootballFanPlatform.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
            
        }
    }
}
