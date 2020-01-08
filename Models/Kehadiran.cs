using System;
using System.ComponentModel.DataAnnotations;

namespace AbsenMahasiswaRazor.Models
{
    public class Kehadiran
    {
        [Key]
        public int Id { get; set; }

        public int nim { get; set; }

        public int status { get; set; }

        string _waktu;
        public string waktu
        {
            get { return DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"); }
            set { _waktu = value; }
        }
    }
}
