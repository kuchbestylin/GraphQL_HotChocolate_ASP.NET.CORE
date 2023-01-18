using Microsoft.EntityFrameworkCore;

namespace GraphQL_HotChocolate_ASP.NET_CORE_.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id= 1,
                        Name= "Samantha El-Shawray",
                        Designation="Center Forward"
                    },
                    new Employee
                    {
                        Id= 2,
                        Name= "Unai Simpsom",
                        Designation="Central Devensive Midfield"
                    },
                    new Employee
                    {
                        Id= 3,
                        Name= "Given Mkron",
                        Designation="Holding Midfield"
                    },
                    new Employee
                    {
                        Id= 4,
                        Name= "Ashwin Randa",
                        Designation="Weeket Keeper"
                    },
                    new Employee
                    {
                        Id= 5,
                        Name= "Rahul Dev",
                        Designation="First Order batsman"
                    }

                );
        }
    }
}
