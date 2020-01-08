using Microsoft.EntityFrameworkCore;

namespace AbsenMahasiswaRazor.Models
{
    public partial class KehadiranContext : DbContext
    {
        public virtual DbSet<Kehadiran> kehadiran { get; set; }

        public KehadiranContext(DbContextOptions<KehadiranContext> options) : base(options)
        {

        }
    }
}
