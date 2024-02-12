using Microsoft.EntityFrameworkCore;

namespace StarSoft.Core.Data
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}