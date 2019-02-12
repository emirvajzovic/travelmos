using travelmos.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace travelmos.EF
{
    public class MojContext : DbContext
    {
        public MojContext(DbContextOptions<MojContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Guide> Guide { get; set; }
        public DbSet<Tourist> Tourist { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Offer> Offer { get; set; }
        public DbSet<UserUserType> UserUserType { get; set; }
    }
}
