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
    public class PrijavaModel : PageModel
    {
        [BindProperty]

        public InputModel Input { get; set; } = new InputModel();

        public class InputModel
        {
            public string? LoginEmail { get; set; }
            public string? LoginPassword { get; set; }
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostLoginAsync()
        {
            using (var connection = ConnectionHelper.GetConnection())
            {
                connection.Open();

                using (var command = new OleDbCommand("SELECT * FROM Users WHERE Email = ? AND Password = ?", connection))
                {
                    command.Parameters.AddWithValue("@Email", Input.LoginEmail);
                    command.Parameters.AddWithValue("@Password", Input.LoginPassword);

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            return RedirectToPage("/Glavna");
                        }
                        else
                        {
                        }
                    }
                }
            }
            return Page();
        }
    }
}
