using Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dal.Ef
{
    public class VictimContext : DbContext
    {
        public VictimContext(DbContextOptions<VictimContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
    }
}