using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;
using Machine_arts.UtilitiesHelpers;
using System.Data.OleDb;
using System.Runtime.Versioning;

namespace Machine_arts.Pages
{
    [SupportedOSPlatform("windows")]
    public class RegistracijaModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new InputModel();

        public class InputModel
        {
            public string? RegisterUsername { get; set; }
            public string? RegisterEmail { get; set; }
            public string? RegisterPassword { get; set; }
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostRegisterAsync()
        {
            using (var connection = ConnectionHelper.GetConnection())
            {
                connection.Open();

                using (var checkEmailCommand = new OleDbCommand("SELECT COUNT(*) FROM Users WHERE [Email] = ?", connection))
                {
                    checkEmailCommand.Parameters.AddWithValue("@Email", Input.RegisterEmail);
                    int existingEmailCount = (int)(await checkEmailCommand.ExecuteScalarAsync() ?? 0);


                    if (existingEmailCount > 0)
                    {
                        ModelState.AddModelError("Input.RegisterEmail", "An account with this email already exists.");
                        return Page();
                    }
                }

                using (var command = new OleDbCommand("INSERT INTO Users ([Username], [Email], [Password]) VALUES (?, ?, ?)", connection))
                {
                    command.Parameters.AddWithValue("@Username", Input.RegisterUsername);
                    command.Parameters.AddWithValue("@Email", Input.RegisterEmail);
                    command.Parameters.AddWithValue("@Password", Input.RegisterPassword);
                    await command.ExecuteNonQueryAsync();
                    return RedirectToPage("/Glavna");

                }
            }
        }
    }
}
