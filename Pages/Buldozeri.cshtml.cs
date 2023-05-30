using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Data.OleDb;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Machine_arts.UtilitiesHelpers;
using Machine_arts.Models;

namespace Machine_arts.Pages
{
    public class BuldozeriModel : PageModel
    {
        public List<Buldozer> Buldozeri { get; set; }

        private readonly Machine_arts.Data.MachineArtsContext _context;

        public BuldozeriModel(Machine_arts.Data.MachineArtsContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            var buldozeri = from g in _context.Buldozer select g;
            Buldozeri = buldozeri.ToList();
        }
    }
}
