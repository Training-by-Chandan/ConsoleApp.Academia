using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.ORM
{
    public class DefaultContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-C25RLDB\\SQLEXPRESS;Initial Catalog=Academia;integrated security=true;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}