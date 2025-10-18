using CastingCallAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CastingCallAPI.Data
{
    public class CastingCallDbContext : DbContext
    {
        public CastingCallDbContext(DbContextOptions<CastingCallDbContext> options) : base(options)
        {
            
        }

        public DbSet<CastingCall>CastingCallsTable { get; set; }
    }
}
