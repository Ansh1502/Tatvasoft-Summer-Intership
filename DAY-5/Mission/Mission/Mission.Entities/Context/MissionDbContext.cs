using Microsoft.EntityFrameworkCore;
using Mission.Entities.Entities;

namespace Mission.Entities.Context
{
    public class MissionDbContext:DbContext
    {
        public MissionDbContext(DbContextOptions<MissionDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = 1,
                FirstName = "ansh",
                LastName = "patel",
                EmailAddress = "gp285376@gmail.com",
                UserType = "aki",
                Password = "ansh@123",
                PhoneNumber = "9855285858",
                CreatedDate = new DateTime(2019, 1, 1, 0, 0, 0, DateTimeKind.Utc)
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
