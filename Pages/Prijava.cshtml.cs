using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;
using Machine_arts.UtilitiesHelpers;
using System.Data.OleDb;
using System.Runtime.Versioning;
using Machine_arts.Models;

namespace Machine_arts.Pages
{
    [SupportedOSPlatform("windows")]
    public class PrijavaModel : PageModel
    {
        private readonly Machine_arts.Data.MachineArtsContext _context;

        [BindProperty]
        public UserLogin LoginCredentials { get; set; } = new UserLogin();

        public PrijavaModel(Machine_arts.Data.MachineArtsContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostLoginAsync()
        {
    

            try {
                var user = _context.User.First<User>(u => u.Email == LoginCredentials.LoginEmail);
                Console.WriteLine(user.Email);

                return RedirectToPage("/Glavna");
            } catch(Exception e) when (e is ArgumentNullException || e is InvalidOperationException) {
                return Page();
            }
        }
    }
}
