using Microsoft.EntityFrameworkCore;

namespace AbsenMahasiswaRazor.Models
{
    public partial class UserContext : DbContext
    {
        public virtual DbSet<User> User { get; set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("mahasiswa");

                entity.Property(e => e.nim)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
