using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Data.OleDb;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Machine_arts.UtilitiesHelpers;

namespace Machine_arts.Pages
{
    public class Predmet9
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Slika { get; set; }

        public string Cijena { get; set; }
        public string Specifikacije { get; set; }

    }
    public class TegljačiModel : PageModel
    {
        public List<Predmet9> Predmeti { get; set; }

        public async Task OnGetAsync()
        {
            using (var connection = ConnectionHelper.GetConnection())
            {
                await connection.OpenAsync();

                using (var command = new OleDbCommand("SELECT * FROM Tegljaci", connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        Predmeti = new List<Predmet9>();
                        while (await reader.ReadAsync())
                        {
                            var predmet = new Predmet9
                            {
                                ID = reader.GetInt32(0),
                                Ime = reader.GetString(1),
                                Slika = reader.GetString(2),
                                Cijena = reader.GetString(3),
                                Specifikacije = reader.IsDBNull(4) ? null : reader.GetString(4)
                            };
                            Predmeti.Add(predmet);
                        }
                    }
                }
            }
        }
    }
}
