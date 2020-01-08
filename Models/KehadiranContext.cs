using Microsoft.EntityFrameworkCore;

namespace AbsenMahasiswaRazor.Models
{
    public partial class KehadiranContext : DbContext
    {
        public virtual DbSet<Kehadiran> kehadiran { get; set; }

        public KehadiranContext(DbContextOptions<KehadiranContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kehadiran>(entity =>
            {
                entity.ToTable("kehadiran");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.nim)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.waktu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
