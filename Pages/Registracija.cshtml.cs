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
    public class RegistracijaModel : PageModel
    {
        private readonly Machine_arts.Data.MachineArtsContext _context;

        [BindProperty]
        public UserRegistration RegistrationCredentials { get; set; } = new UserRegistration();

        public RegistracijaModel(Machine_arts.Data.MachineArtsContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostRegisterAsync()
        {
            try {
                var user = _context.User.First<User>(u => u.Email == RegistrationCredentials.RegisterEmail);
                ModelState.AddModelError("Input.RegisterEmail", "An account with this email already exists.");
                return Page();
            } catch(Exception e) when (e is ArgumentNullException || e is InvalidOperationException) {
                var NewUser = new User() {
                    Username = RegistrationCredentials.RegisterUsername,
                    Email = RegistrationCredentials.RegisterEmail,
                    Password = RegistrationCredentials.RegisterPassword
                };
                _context.User.Add(NewUser);
                await _context.SaveChangesAsync();
                return RedirectToPage("/Glavna");
            }
        }
    }
}
