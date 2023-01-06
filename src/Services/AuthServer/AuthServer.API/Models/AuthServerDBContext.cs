using AuthServer.API.Data;
using Microsoft.EntityFrameworkCore;

namespace AuthServer.API.Models
{
    public partial class AuthServerDBContext : DbContext
    {
        public AuthServerDBContext()
        {
        }

        public AuthServerDBContext(DbContextOptions<AuthServerDBContext> options)
            : base(options)
        {
            if(Database.GetAppliedMigrations().ToList().Count == 0)
            {
                Database.Migrate();
            }            
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost,1433;Database=AuthServerDB;User Id=sa;Password=password123*;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedData.SeedUser(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
