using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AbsenMahasiswaRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace AbsenMahasiswaRazor.Pages.Absen
{
    public class IndexModel : PageModel
    {
        private readonly UserContext userContext;
        private readonly KehadiranContext kehadiranContext;

        public IndexModel(UserContext contextUser, KehadiranContext contextKehadiran)
        {
            userContext = contextUser;
            kehadiranContext = contextKehadiran;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AbsenModel Model { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var userdetails = await userContext.User.SingleOrDefaultAsync(User => User.nim == Model.nim);
                if (userdetails == null)
                {
                    ModelState.AddModelError("", "NIM Tidak Ditemukan");
                    return Page();
                }
                else
                {
                    Kehadiran kehadiran1 = new Kehadiran
                    {
                        nim = Model.nim,
                        status = 1
                    };
                    kehadiranContext.kehadiran.Add(kehadiran1);
                    await kehadiranContext.SaveChangesAsync();
                    ViewData["success"] = "Berhasil Absen";

                    return Page();
                }
            }
            return Page();
        }       
    }
}