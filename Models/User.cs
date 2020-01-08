using System.ComponentModel.DataAnnotations;

namespace AbsenMahasiswaRazor.Models
{
    public class User
    {
        [Key]
        [Required]
        public int nim { get; set; }
    }
}
