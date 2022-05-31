using Microsoft.EntityFrameworkCore;

namespace SecondTask.Data
{
    public class SecondDbContext : DbContext

    {
        public SecondDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<EsplEmployee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<EsplEmployee>().HasData(
                new EsplEmployee
                {
                    ID = 1,
                   Name="Home"
                },
                 new EsplEmployee
                 {
                     ID=2,
                    Name="Open"
                 },
                  new EsplEmployee
                  {
                      ID = 3,
                      Name = "Completed"
                  },
                  new EsplEmployee
                  {
                      ID=4,
                      Name="Pending"
                  },
                  new EsplEmployee
                  {
                      ID = 5,
                      Name = "Pree Review"
                  });
    } 
    }


}

